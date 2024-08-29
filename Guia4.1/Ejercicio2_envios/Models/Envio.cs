using System;
using System.Collections;

namespace Ejercicio2.Models
{
    public class Envio:IComparable
    {
        private ArrayList costos = new ArrayList();

        public int CodigoAduanero { get; set; }

        public double ValorTotal
        {
            get
            {
                double total = 0;
                foreach (Costo c in costos)
                {
                    total += c.ValorFinal;
                }
                return total;
            }
        }

        public Envio(int codigoAduanero)
        {
            this.CodigoAduanero = codigoAduanero;
        }

        public void AgregarCosto(Costo nuevo)
        {
            costos.Add(nuevo);
        }

        public string VerDetalle() 
        {
            string detalle = "";
            foreach (Costo c in costos)
            {
                detalle += c.VerDetalle();
            }
            return detalle;
        }

        public int CompareTo(object obj)
        {
            Envio envio = obj as Envio;

            if (envio == null)
                return CodigoAduanero.CompareTo(envio.CodigoAduanero);
            else 
                return -1;
        }
    }
}
