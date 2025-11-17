using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA.Modelos
{
    public class Nodo
    {
        public string Nombre { get; set; }
        public List<Arista> Adyacentes { get; set; }

        public Nodo(string nombre)
        {
            Nombre = nombre;
            Adyacentes = new List<Arista>();
        }
    }
}
