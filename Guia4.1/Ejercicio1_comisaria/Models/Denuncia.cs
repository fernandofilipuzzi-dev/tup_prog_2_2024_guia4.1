using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Denuncia : IComparable
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public int NumeroPlaca { get; set; }

        public Denuncia(int dni, string nombre, int numeroPlaca)
        {
            DNI = dni;
        }

        public override string ToString()
        {
            return $"{DNI}{Nombre}{NumeroPlaca}";
        }

        public int CompareTo(object obj)
        {
            Denuncia policia = obj as Denuncia;
            if (policia != null)
            {
                return policia.NumeroPlaca.CompareTo(policia.NumeroPlaca);
            }
            return -1;
        }
    }
}
