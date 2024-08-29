

namespace Ejercicio2.Models
{
    public class Variable:Costo
    {
        public double PrecioPorUnidad { get; set; }
        public double Unidades { get; set; }

        public override double ValorFinal 
        {
            get 
            {
                return PrecioPorUnidad*Unidades;
            }
        }

        public Variable(string concepto, double precioPorUnidad, double unidades) : base(concepto)
        {
            PrecioPorUnidad = precioPorUnidad;
            Unidades = unidades;
        }

        override public string VerDetalle()
        {
            return $"{Concepto:10}({PrecioPorUnidad:f2}x{Unidades:f2}){ValorFinal,10:f2}\r\n";
        }

        public override string ToString()
        {
            return $"{Concepto}";
        }
    }
}
