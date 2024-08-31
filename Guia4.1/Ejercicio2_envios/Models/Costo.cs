


namespace Ejercicio2.Models
{
    abstract public class Costo
    {
        public string Concepto { get; }

        virtual public double ValorFinal { get; protected set; }//necesito el protected set sino no lo puedo setearlo desde las derivadas

        public Costo(string concepto) 
        {
            Concepto = concepto;
        }
    }
}
