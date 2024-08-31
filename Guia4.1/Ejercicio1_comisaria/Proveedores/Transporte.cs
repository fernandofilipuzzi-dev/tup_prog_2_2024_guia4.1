using Ejercicio1.API;

namespace Ejercicio1.Proveedores
{
    public class Transporte : IProcesadorEnvios
    {
        double distanciaKm;
        double precioPorKm;

        public Transporte(double distanciaKM, double precioPorKM)
        {
            this.distanciaKm=distanciaKM;
            this.precioPorKm=precioPorKM;
        }

        public void ProcesarEnvios(IProcesable[] envios)
        {
            if (envios!=null && envios.Length > 0)
            {
                double valorPorProducto = distanciaKm*precioPorKm/envios.Length;

                foreach (IProcesable p in envios)
                {
                    p.CrearCosto("Costo de transporte por unidad", valorPorProducto);
                }
            }
        }
    }
}
