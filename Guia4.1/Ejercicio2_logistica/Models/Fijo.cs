
namespace Ejercicio2.Models
{
    public class Fijo : Costo
    {
        public Fijo(string concepto, double ValorFinal):base(concepto)
        {
            base.ValorFinal = ValorFinal;
        }

        public override string ToString() 
        {
            return $"{Concepto:15} {ValorFinal:10}";
        }
    }
}
