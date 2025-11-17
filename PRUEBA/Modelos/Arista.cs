using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA.Modelos
{
    public class Arista
    {
        public Nodo Destino { get; set; }
        public int Peso { get; set; }

        public Arista(Nodo destino, int peso)
        {
            Destino = destino;
            Peso = peso;
        }
    }
}
