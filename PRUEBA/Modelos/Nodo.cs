using System.Collections.Generic;
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
