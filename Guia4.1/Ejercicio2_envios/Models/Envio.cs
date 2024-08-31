using System;
using System.Collections;

namespace Ejercicio2.Models
{
    public class Envio : IComparable
    {
        public int CodigoAduanero { get; private set; }
        public string Empresa { get; private set; }

        public ArrayList costos = new ArrayList();

        public double ValorFinal
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
        public int CantidadCostos
        {
            get
            {
                if (costos != null)
                    return costos.Count;
                else return 0;
            }
        }

        
        public Envio(int codigoAduanero, string empresa)
        {
            this.CodigoAduanero = codigoAduanero;
            this.Empresa = empresa;
        }

        public void AgregarCosto(Costo nuevo) 
        {
            costos.Add(nuevo);
        }

        public int CompareTo(object obj)
        {
            Envio envio = obj as Envio;
            if (envio != null)
            {
                return CodigoAduanero.CompareTo(envio.CodigoAduanero);
            }
            return 1;
        }

        public override string ToString()
        {
            return $"Envío: {CodigoAduanero,10:000000} Empresa:{Empresa}";
        }
    }
}
