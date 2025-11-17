using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA.Modelos
{
    public class Grafo
    {
        public List<Nodo> Nodos { get; set; }

        public Grafo()
        {
            Nodos = new List<Nodo>();
        }

        /// <summary>
        /// Agregar nodo
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public bool AgregarNodo(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre)) return false;
            if (Nodos.Any(n => n.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase)))
                return false;

            Nodos.Add(new Nodo(nombre));
            return true;
        }

        /// <summary>
        /// Agregar arista
        /// </summary>
        /// <param name="origen"></param>
        /// <param name="destino"></param>
        /// <param name="peso"></param>
        /// <returns></returns>
        public bool AgregarArista(string origen, string destino, int peso)
        {
            if (origen == destino) return false;

            Nodo n1 = Nodos.Find(n => n.Nombre == origen);
            Nodo n2 = Nodos.Find(n => n.Nombre == destino);

            if (n1 == null || n2 == null) return false;

            // evitar duplicados
            bool existe = n1.Adyacentes.Any(a => a.Destino == n2);
            if (existe) return false;

            n1.Adyacentes.Add(new Arista(n2, peso));
            n2.Adyacentes.Add(new Arista(n1, peso));
            return true;
        }

        /// <summary>
        /// Mostrar adyacencias
        /// </summary>
        /// <returns></returns>
        public List<string> MostrarAdyacencia()
        {
            List<string> salida = new List<string>();

            foreach (var nodo in Nodos)
            {
                string linea = nodo.Nombre + " → ";
                linea += string.Join(", ", nodo.Adyacentes.Select(a => $"{a.Destino.Nombre}({a.Peso})"));
                salida.Add(linea);
            }

            return salida;
        }

        /// <summary>
        /// Validar conexidad
        /// </summary>
        /// <returns></returns>
        public bool EsConexo()
        {
            if (Nodos.Count == 0) return false;

            HashSet<Nodo> visitados = new HashSet<Nodo>();
            DFS(Nodos[0], visitados);

            return visitados.Count == Nodos.Count;
        }

        private void DFS(Nodo actual, HashSet<Nodo> visitados)
        {
            visitados.Add(actual);

            foreach (var arista in actual.Adyacentes)
            {
                if (!visitados.Contains(arista.Destino))
                    DFS(arista.Destino, visitados);
            }
        }

       
        /// <summary>
        /// Dijkstra — Ruta más corta
        /// </summary>
        /// <param name="inicio"></param>
        /// <param name="fin"></param>
        /// <returns></returns>
        public List<string> Dijkstra(string inicio, string fin)
        {
            Nodo start = Nodos.Find(n => n.Nombre == inicio);
            Nodo end = Nodos.Find(n => n.Nombre == fin);

            if (start == null || end == null) return new List<string>();

            Dictionary<Nodo, int> dist = new Dictionary<Nodo, int>();
            Dictionary<Nodo, Nodo> previo = new Dictionary<Nodo, Nodo>();
            List<Nodo> nodosNoVisitados = new List<Nodo>();

            foreach (var nodo in Nodos)
            {
                dist[nodo] = int.MaxValue;
                previo[nodo] = null;
                nodosNoVisitados.Add(nodo);
            }

            dist[start] = 0;

            while (nodosNoVisitados.Count > 0)
            {
                nodosNoVisitados = nodosNoVisitados.OrderBy(n => dist[n]).ToList();
                Nodo actual = nodosNoVisitados[0];
                nodosNoVisitados.RemoveAt(0);

                if (dist[actual] == int.MaxValue) break; // nodos desconectados

                foreach (var arista in actual.Adyacentes)
                {
                    int posibleDistancia = dist[actual] + arista.Peso;
                    if (posibleDistancia < dist[arista.Destino])
                    {
                        dist[arista.Destino] = posibleDistancia;
                        previo[arista.Destino] = actual;
                    }
                }
            }

            // si el final no fue alcanzado
            if (dist[end] == int.MaxValue) return new List<string>();

            // Construir ruta
            List<string> ruta = new List<string>();
            Nodo temp = end;
            while (temp != null)
            {
                ruta.Add(temp.Nombre);
                temp = previo[temp];
            }
            ruta.Reverse();
            return ruta;
        }

        /// <summary>
        /// Calcular la distancia total
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        public int CalcularDistanciaRuta(List<string> ruta)
        {
            if (ruta == null || ruta.Count < 2) return 0;

            int total = 0;
            for (int i = 0; i < ruta.Count - 1; i++)
            {
                Nodo a = Nodos.Find(n => n.Nombre == ruta[i]);
                Nodo b = Nodos.Find(n => n.Nombre == ruta[i + 1]);
                if (a == null || b == null) return int.MaxValue;

                Arista ar = a.Adyacentes.Find(x => x.Destino == b);
                if (ar == null) return int.MaxValue;

                total += ar.Peso;
            }
            return total;
        }

        // Opcional: Recorridos públicos (DFS/BFS) desde un inicio
        public List<string> RecorridoDFS(string inicio)
        {
            Nodo start = Nodos.Find(n => n.Nombre == inicio);
            if (start == null) return new List<string>();

            HashSet<Nodo> vs = new HashSet<Nodo>();
            List<string> res = new List<string>();
            DFS_Recorrido(start, vs, res);
            return res;
        }

        private void DFS_Recorrido(Nodo actual, HashSet<Nodo> visitados, List<string> recorrido)
        {
            visitados.Add(actual);
            recorrido.Add(actual.Nombre);
            foreach (var ar in actual.Adyacentes)
                if (!visitados.Contains(ar.Destino))
                    DFS_Recorrido(ar.Destino, visitados, recorrido);
        }

        public List<string> RecorridoBFS(string inicio)
        {
            Nodo start = Nodos.Find(n => n.Nombre == inicio);
            if (start == null) return new List<string>();

            Queue<Nodo> q = new Queue<Nodo>();
            HashSet<Nodo> vs = new HashSet<Nodo>();
            List<string> res = new List<string>();

            q.Enqueue(start);
            while (q.Count > 0)
            {
                var cur = q.Dequeue();
                if (vs.Contains(cur)) continue;
                vs.Add(cur);
                res.Add(cur.Nombre);
                foreach (var ar in cur.Adyacentes)
                    if (!vs.Contains(ar.Destino))
                        q.Enqueue(ar.Destino);
            }
            return res;
        }
    }
}
