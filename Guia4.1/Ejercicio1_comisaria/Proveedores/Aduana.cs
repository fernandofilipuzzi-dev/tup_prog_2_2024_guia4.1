
using Ejercicio1.API;

namespace Ejercicio1.Proveedores
{
    public class Aduana : IProcesadorEnvios
    {
        double valorFijo;

        public Aduana(double valorFijo)
        {
            this.valorFijo = valorFijo;
        }

        public void ProcesarEnvios(IProcesable[] envios)
        {
            
            double valorPorProducto = valorFijo;

            if(envios!=null)
                foreach (IProcesable p in envios)
                {
                    p.CrearCosto("Costo aduanero", valorPorProducto);
                }
        }

    }
}
