using PRUEBA.Modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PRUEBA.Vista
{
    public partial class FrmGrafo : Form
    {
        private Grafo grafo = new Grafo();
        private Dictionary<Nodo, Point> posicionesNodos = new Dictionary<Nodo, Point>();
        private Nodo nodoSeleccionado = null; // Para arrastrar nodos
        private Point offset; // Offset para el arrastre
        private int radioNodo = 25; // Radio de los círculos de los nodos
        public FrmGrafo()
        {
            InitializeComponent();
            nudDistancia.Minimum = 1;
            nudDistancia.Maximum = 9999;

            // Configuración del PictureBox
            pbGrafo.Paint += pbGrafo_Paint;
            pbGrafo.MouseDown += pbGrafo_MouseDown;
            pbGrafo.MouseMove += pbGrafo_MouseMove;
            pbGrafo.MouseUp += pbGrafo_MouseUp;
            pbGrafo.BackColor = Color.LightGray; // Un fondo claro para el grafo

            // Para evitar parpadeo al redibujar
            this.DoubleBuffered = true;
        }

        private void btnAgregarE_Click(object sender, EventArgs e)
        {
            string nombre = tbEdificio.Text.Trim();
            if (nombre == "")
            {
                MessageBox.Show("Ingrese el nombre del edificio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool ok = grafo.AgregarNodo(nombre);
            if (!ok)
            {
                MessageBox.Show("No se agregó. Posible duplicado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar el nodo recién creado para darle posición
            Nodo nuevoNodo = grafo.Nodos.Find(n => n.Nombre == nombre);
            if (nuevoNodo != null)
            {
                // Asignar una posición aleatoria dentro del PictureBox
                Random rnd = new Random();
                int x = rnd.Next(50, pbGrafo.Width - 50);  // Márgenes de 50px
                int y = rnd.Next(50, pbGrafo.Height - 50); // Márgenes de 50px
                posicionesNodos[nuevoNodo] = new Point(x, y);
            }

            // actualizar comboBox
            cmbOrigen.Items.Add(nombre);
            cmbDestino.Items.Add(nombre);
            cmbInicio.Items.Add(nombre);
            cmbFin.Items.Add(nombre);

            tbEdificio.Clear();
            tbEdificio.Focus();

            pbGrafo.Invalidate(); // Redibuja el grafo para mostrar el nuevo nodo
        }

        private void btnAgregarConex_Click(object sender, EventArgs e)
        {
            if (cmbOrigen.SelectedItem == null || cmbDestino.SelectedItem == null)
            {
                MessageBox.Show("Seleccione origen y destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string origen = cmbOrigen.SelectedItem.ToString();
            string destino = cmbDestino.SelectedItem.ToString();
            int distancia = (int)nudDistancia.Value;

            bool ok = grafo.AgregarArista(origen, destino, distancia);
            if (!ok)
            {
                MessageBox.Show("No se pudo agregar la conexión (quizás ya existe o los datos son inválidos).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Conexión agregada.");

            pbGrafo.Invalidate(); // Redibuja el grafo para mostrar la nueva conexión
        }

        private void btnMostrarAd_Click(object sender, EventArgs e)
        {
            lbAdyacencias.Items.Clear();
            var lista = grafo.MostrarAdyacencia();
            foreach (var linea in lista)
                lbAdyacencias.Items.Add(linea);
        }

        private void btnConexidad_Click(object sender, EventArgs e)
        {
            bool conexo = grafo.EsConexo();
            lblConexo.Text = conexo ? "Conexo" : "No conexo";
        }

        private void btnRutaCorta_Click(object sender, EventArgs e)
        {
            if (cmbInicio.SelectedItem == null || cmbFin.SelectedItem == null)
            {
                MessageBox.Show("Seleccione nodo inicio y fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string inicio = cmbInicio.SelectedItem.ToString();
            string fin = cmbFin.SelectedItem.ToString();

            if (inicio == fin)
            {
                lbRutaCorta.Items.Clear();
                lbRutaCorta.Items.Add("Inicio y fin son el mismo nodo: " + inicio);
                return;
            }

            List<string> ruta = grafo.Dijkstra(inicio, fin);

            lbRutaCorta.Items.Clear();

            if (ruta == null || ruta.Count == 0)
            {
                lbRutaCorta.Items.Add("No existe ruta entre los nodos seleccionados.");
                return;
            }

            // Mostrar la ruta en una línea y luego la distancia total
            lbRutaCorta.Items.Add("Ruta:");
            lbRutaCorta.Items.Add(string.Join(" → ", ruta));

            int distanciaTotal = grafo.CalcularDistanciaRuta(ruta);
            if (distanciaTotal == int.MaxValue)
                lbRutaCorta.Items.Add("Error calculando distancia (aristas faltantes).");
            else
                lbRutaCorta.Items.Add("Distancia total: " + distanciaTotal.ToString());

            pbGrafo.Invalidate(); // Redibuja el grafo para resaltar la ruta encontrada
        }

        private void pbGrafo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int radioNodo = 25; // Radio de los círculos de los nodos
            Font fontNodo = new Font("Arial", 9);
            StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

            // 1. Dibujar aristas (conexiones)
            foreach (var nodoOrigen in grafo.Nodos)
            {
                Point p1 = posicionesNodos.ContainsKey(nodoOrigen) ? posicionesNodos[nodoOrigen] : Point.Empty;
                if (p1 == Point.Empty) continue; // Si no tiene posición, no dibujamos

                foreach (var arista in nodoOrigen.Adyacentes)
                {
                    Nodo nodoDestino = arista.Destino;
                    Point p2 = posicionesNodos.ContainsKey(nodoDestino) ? posicionesNodos[nodoDestino] : Point.Empty;
                    if (p2 == Point.Empty) continue;

                    // Para evitar dibujar la misma arista dos veces (grafo no dirigido)
                    if (string.Compare(nodoOrigen.Nombre, nodoDestino.Nombre, StringComparison.Ordinal) < 0)
                    {
                        // Determinar el color de la arista
                        Pen lapizArista = new Pen(Color.DimGray, 2);

                        // Si estás mostrando la ruta más corta y quieres resaltarla
                        if (lbRutaCorta.Items.Count > 1 && lbRutaCorta.Items[0].ToString() == "Ruta:")
                        {
                            List<string> rutaStr = lbRutaCorta.Items[1].ToString().Split(new string[] { " → " }, StringSplitOptions.None).ToList();
                            bool isPartofRoute = false;
                            for (int i = 0; i < rutaStr.Count - 1; i++)
                            {
                                if ((rutaStr[i] == nodoOrigen.Nombre && rutaStr[i + 1] == nodoDestino.Nombre) ||
                                    (rutaStr[i + 1] == nodoOrigen.Nombre && rutaStr[i] == nodoDestino.Nombre))
                                {
                                    isPartofRoute = true;
                                    break;
                                }
                            }
                            if (isPartofRoute)
                            {
                                lapizArista = new Pen(Color.Red, 3); // Resaltar ruta
                            }
                        }

                        g.DrawLine(lapizArista, p1, p2);

                        // Dibujar el peso de la arista
                        Point midPoint = new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
                        g.FillRectangle(Brushes.White, midPoint.X - 15, midPoint.Y - 10, 30, 20); // Fondo para el texto
                        g.DrawString(arista.Peso.ToString(), fontNodo, Brushes.Black, midPoint, sf);
                    }
                }
            }

            // 2. Dibujar nodos (círculos y texto)  
            foreach (var par in posicionesNodos)
            {
                Nodo nodo = par.Key;
                Point centro = par.Value;

                Rectangle rect = new Rectangle(centro.X - radioNodo, centro.Y - radioNodo, radioNodo * 2, radioNodo * 2);

                // Fondo del nodo
                g.FillEllipse(Brushes.LightCoral, rect);
                // Borde del nodo
                g.DrawEllipse(Pens.Black, rect);

                // Nombre del nodo
                g.DrawString(nodo.Nombre, fontNodo, Brushes.Black, centro, sf);
            }
        }

        private void pbGrafo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int radioNodo = 25;
                foreach (var par in posicionesNodos)
                {
                    Nodo nodo = par.Key;
                    Point centro = par.Value;

                    // Verificar si el clic está dentro de un nodo
                    if (Math.Abs(e.X - centro.X) < radioNodo && Math.Abs(e.Y - centro.Y) < radioNodo)
                    {
                        nodoSeleccionado = nodo;
                        offset = new Point(e.X - centro.X, e.Y - centro.Y); // Calcular offset
                        break;
                    }
                }
            }
        }

        private void pbGrafo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && nodoSeleccionado != null)
            {
                // Mover el nodo a la nueva posición
                Point nuevaPos = new Point(e.X - offset.X, e.Y - offset.Y);

                // Asegurarse de que el nodo no se salga de los límites
                nuevaPos.X = Math.Max(radioNodo, Math.Min(pbGrafo.Width - radioNodo, nuevaPos.X));
                nuevaPos.Y = Math.Max(radioNodo, Math.Min(pbGrafo.Height - radioNodo, nuevaPos.Y));

                posicionesNodos[nodoSeleccionado] = nuevaPos;
                pbGrafo.Invalidate(); // Redibujar el grafo
            }
        }

        private void pbGrafo_MouseUp(object sender, MouseEventArgs e)
        {
            nodoSeleccionado = null; // Liberar el nodo
        }
    }
}
