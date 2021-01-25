using System;

namespace RhinoMock
{
    public class Transporte : ITransporte
    {
        public Transporte()
        {
        }
        public int Capacidad { get; set; }
        public int CargaActual { get; private set; }

        public int Cargar(int peso)
        {
             return CargaActual + peso;
        }

        public double PorcentajeCarga()
        {
            return CargaActual / Convert.ToDouble(Capacidad);
        }
    }
}