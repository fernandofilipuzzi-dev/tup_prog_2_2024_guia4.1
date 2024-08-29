using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    abstract public class Costo
    {
        public string Concepto { get; private set; }
        virtual public double ValorFinal { get; protected set; }

        public Costo(string concepto)
        {
            this.Concepto = concepto;
        }
        abstract public string VerDetalle();
    }
}
