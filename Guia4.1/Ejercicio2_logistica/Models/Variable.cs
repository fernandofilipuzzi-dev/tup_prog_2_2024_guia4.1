
namespace Ejercicio2.Models
{
    public class Variable : Costo
    {
        public double PrecioPorUnidad { get; }
        public double Unidades { get; }
        
        override public double ValorFinal 
        { 
            get 
            { 
                return Unidades*PrecioPorUnidad;
            } 
        }

        public Variable(string concepto, double unidades, double precioPorUnidad) : base(concepto)
        {
            PrecioPorUnidad = precioPorUnidad;
            Unidades = unidades;
        }

        override public string ToString()
        {
            return $"{Concepto:15} {ValorFinal:10}";
        }
    }
}
