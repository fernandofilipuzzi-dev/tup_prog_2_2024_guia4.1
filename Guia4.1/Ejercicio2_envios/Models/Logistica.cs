
using System.Collections;

namespace Ejercicio2.Models
{
    public class Logistica
    {
        ArrayList envios =new ArrayList();

        public int CantidadEnvios { get { return envios.Count; } }

        public bool AgregarEnvio(Envio envio)
        {
            int idx = envios.BinarySearch(envio);
            if (idx < 0)
            {
                envios.Add(envio);
                return true;
            }
            return false;
        }

        public Envio VerEnvioPorCodigo(int codigoAduanero)
        {
            int idx = envios.BinarySearch(new Envio(codigoAduanero));
            if(idx>=0)
                return envios[idx] as Envio;
            return null;
        }

        public Envio VerEnvio(int idx)
        {
            return envios[idx] as Envio;
        }
    }
}
