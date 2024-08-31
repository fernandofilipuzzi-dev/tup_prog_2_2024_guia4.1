
namespace Ejercicio1.API
{
    public interface IProcesable
    {
        int CantidadCostos{ get; }
        double CostoTotal { get; }
        ICosto CrearCosto(string concepto, double valor);
        ICosto VerCosto(int idx);
    }
}
