using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRUEBA.Vista
{
    public partial class FrmArbol : Form
    {
        public FrmArbol()
        {
            InitializeComponent();
        }

        private void btnAgregarRaiz_Click(object sender, EventArgs e)
        {
            if (tbNodoRaiz.Text != "")
            {
                tvInnovatec.Nodes.Add(tbNodoRaiz.Text);
                tvInnovatec.ExpandAll();
                tbNodoRaiz.Clear();
                tbNodoRaiz.Focus();
            }
            else
            {
                MessageBox.Show("Debe agregar un valor para el nodo raíz!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarHijo_Click(object sender, EventArgs e)
        {
            if (tvInnovatec.SelectedNode == null)
            {
                MessageBox.Show("Debe seleccionar un nodo padre para agregar un nodo hijo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tbNodoHijo.Text != "")
                {
                    tvInnovatec.SelectedNode.Nodes.Add(tbNodoHijo.Text);
                    tvInnovatec.ExpandAll();
                    tbNodoHijo.Clear();
                    tbNodoHijo.Focus();
                }
                else
                {
                    MessageBox.Show("Debe agregar un valor para el nodo hijo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnRecorrer_Click(object sender, EventArgs e)
        {
            if (tvInnovatec.Nodes.Count == 0)
            {
                MessageBox.Show("No hay nodos para recorrer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Limpiar colores previos
            LimpiarColores(tvInnovatec.Nodes);

            // Recorrer cada raíz en preorden
            foreach (TreeNode nodo in tvInnovatec.Nodes)
            {
                await RecorridoPreordenAnimado(nodo);
            }

            MessageBox.Show("Recorrido completado.", "Recorrido", MessageBoxButtons.OK);
        }

        private async Task RecorridoPreordenAnimado(TreeNode nodo)
        {
            if (nodo == null) return;

            // Pintar nodo visitado
            nodo.BackColor = Color.LightBlue;
            nodo.ForeColor = Color.Black;
            tvInnovatec.SelectedNode = nodo;
            nodo.EnsureVisible();

            // Pausa para mostrar la animación
            await Task.Delay(600);

            // Restaurar colores del nodo
            nodo.BackColor = Color.White;
            nodo.ForeColor = Color.Black;

            // Recorrer hijos en preorden
            foreach (TreeNode hijo in nodo.Nodes)
            {
                await RecorridoPreordenAnimado(hijo);
            }
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (tbBuscar.Text == "")
            {
                MessageBox.Show("Debe escribir el nombre del nodo a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            // Limpiar colores anteriores
            LimpiarColores(tvInnovatec.Nodes);

            TreeNode nodoEncontrado = BuscarNodo(tvInnovatec.Nodes, tbBuscar.Text);

            if (nodoEncontrado != null)
            {
                nodoEncontrado.BackColor = Color.LightBlue;
                nodoEncontrado.ForeColor = Color.Black;
                tvInnovatec.SelectedNode = nodoEncontrado;
                nodoEncontrado.EnsureVisible(); // Asegura que se vea el nodo en el TreeView
                tbBuscar.Clear();
            }
            else
            {
                MessageBox.Show("Nodo no encontrado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private TreeNode BuscarNodo(TreeNodeCollection nodos, string valor)
        {
            foreach (TreeNode nodo in nodos)
            {
                if (nodo.Text.Equals(valor, StringComparison.OrdinalIgnoreCase))
                    return nodo;

                TreeNode encontrado = BuscarNodo(nodo.Nodes, valor);
                if (encontrado != null)
                    return encontrado;
            }
            return null;
        }

        // Función para limpiar colores de todos los nodos
        private void LimpiarColores(TreeNodeCollection nodos)
        {
            foreach (TreeNode nodo in nodos)
            {
                nodo.BackColor = Color.White;
                nodo.ForeColor = Color.Black;
                LimpiarColores(nodo.Nodes);
            }
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int totalNodos = ContarNodos(tvInnovatec.Nodes);
            MessageBox.Show($"El árbol tiene {totalNodos} nodo(s) en total.", "Conteo de Nodos", MessageBoxButtons.OK);
        }

        private int ContarNodos(TreeNodeCollection nodos)
        {
            int contador = 0;

            foreach (TreeNode nodo in nodos)
            {
                contador++; // Contamos el nodo actual
                contador += ContarNodos(nodo.Nodes); // Contamos recursivamente los hijos
            }

            return contador;
        }

        private void btnNivel_Click(object sender, EventArgs e)
        {
            if (tbNivel.Text == "")
            {
                MessageBox.Show("Debe escribir el nombre del nodo para consultar su nivel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TreeNode nodoEncontrado = BuscarNodo(tvInnovatec.Nodes, tbNivel.Text);

            if (nodoEncontrado != null)
            {
                int nivel = nodoEncontrado.Level; // Propiedad Level devuelve el nivel del nodo
                MessageBox.Show($"El nodo '{nodoEncontrado.Text}' está en el nivel {nivel}.", "Nivel del Nodo", MessageBoxButtons.OK);
                tbNivel.Clear();
            }
            else
            {
                MessageBox.Show("Nodo no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
