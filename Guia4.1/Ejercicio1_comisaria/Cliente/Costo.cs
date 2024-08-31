

using Ejercicio1.API;

namespace Ejercicio1.Cliente
{
    public class Costo : ICosto
    {
        public string Concepto { get;  }

        public double Valor { get;  }

        public Costo(string concepto, double valor) 
        {
            Concepto = concepto;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"{Concepto,-35}{Valor,10:f2}";
        }
    }
}
