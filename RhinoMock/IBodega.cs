namespace MockStub
{
    public interface IBodega
    {
        void ActualizarExistencia(string producto, int cantidad);
        void Agregar(string producto, int cantidad);
        int Existencia(string producto);
    }
}