namespace RhinoMock
{
    public interface ITransporte
    {
        int Capacidad { get; set; }

        double PorcentajeCarga();
        int Cargar(int peso);
    }
}