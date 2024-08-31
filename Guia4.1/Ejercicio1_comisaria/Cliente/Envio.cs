using Ejercicio1.API;

using System;
using System.Collections;

namespace Ejercicio1.Cliente
{
    public class Envio : IProcesable, IComparable
    {
        public int NumeroAduanero { get; private set; }
        public double CostoTotal 
        { 
            get 
            {
                double total = 0;
                foreach (ICosto c in costos)
                {
                    total += c.Valor;
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

        public ArrayList costos = new ArrayList();


        public Envio(int numeroAduanero)
        {
            this.NumeroAduanero = numeroAduanero;
        }

        public override string ToString()
        {
            return $"Envío: {NumeroAduanero,10:000000}";
        }

        public ICosto VerCosto(int idx)
        {
            if(idx>=0 && idx<CantidadCostos)
                return costos[idx] as ICosto;
            return null;
        }

        public int CompareTo(object obj)
        {
            Envio envio = obj as Envio;
            if (envio != null)
            {
                return NumeroAduanero.CompareTo(envio.NumeroAduanero);
            }
            return -1;
        }

        public ICosto CrearCosto(string concepto, double valor)
        {
            ICosto c = new Costo(concepto, valor);
            costos.Add(c);
            return c;
        }
    }
}
