using System;

namespace RhinoMock
{
    internal class Mercancia
    {
        public Mercancia()
        {
        }

        public int Peso { get; internal set; }
        public bool SeEnvio { get; internal set; }

        internal void Enviar(ITransporte transporte)
        {
            if (transporte.PorcentajeCarga() >= 0.5)
            {
                transporte.Cargar(this.Peso);
                this.SeEnvio = true;
            }
            else
            {
                this.SeEnvio = false;
            }

        }
    }
}