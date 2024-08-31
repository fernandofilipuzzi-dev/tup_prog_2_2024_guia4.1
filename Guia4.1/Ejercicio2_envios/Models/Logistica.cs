
using System.Collections;

namespace Ejercicio2.Models
{
    public class Logistica
    {
        ArrayList envios = new ArrayList();

        public int CantidadEnvios 
        {
            get 
            {
                if (envios!=null)
                    return envios.Count;
                return 0;
            }
        }
             
        public Envio AgregarEnvio(Envio nuevo)
        {
            envios.Sort();
            int idx=envios.BinarySearch(nuevo);

            if (idx < 0)
            {
                envios.Add(nuevo);
                return nuevo;
            }
            return null;
        }

        public int VerEnvioPorCodigo(int numeroAduanero)
        {
            envios.Sort();
            int idx = envios.BinarySearch(new Envio(numeroAduanero,""));
            return idx;
        }

        public Envio VerEnvio(int idx)
        {
            return envios[idx] as Envio;
        }
    }
}
