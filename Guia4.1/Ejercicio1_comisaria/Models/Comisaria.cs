using System.Collections;
using System.Diagnostics.Eventing.Reader;
namespace Ejercicio1.Models
{
    public class Comisaria
    {
        ArrayList agentes { get; set; } = new ArrayList();

        public int CantidadIncidentes { get; set; }


        public bool AsignarPolicia(Denuncia agente)
        {
            if (agentes.BinarySearch(agente) <= 0)
            {
                agentes.Add(agente);
                return true;
            }

            return false;
        }

        public Denuncia VerAgente(int numeroPlaca)
        {
            agentes.Sort();
            int idx = agentes.BinarySearch(new Denuncia(0,"",numeroPlaca));
            if (idx >= 0)
            {
                return agentes[idx] as Denuncia;
            }
            return null;
        }
    }
}
