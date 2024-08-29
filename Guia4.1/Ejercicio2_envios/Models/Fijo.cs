
namespace Ejercicio2.Models
{
    public class Fijo:Costo
    {
        public Fijo(string concepto, double valorFinal) : base(concepto)
        {
            this.ValorFinal = valorFinal;
        }

        override public string VerDetalle()
        {
            return $"{Concepto:20}{ValorFinal,10:f2}\r\n";
        }

        public override string ToString()
        {
            return $"{Concepto}";
        }
    }
}
