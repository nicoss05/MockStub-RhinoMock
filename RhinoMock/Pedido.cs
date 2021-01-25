using System;

namespace MockStub
{
    internal class Pedido
    {
        private string producto;
        private int cantidad;

        public Pedido(string producto, int cantidad)
        {
            this.producto = producto;
            this.cantidad = cantidad;
        }

        public bool SeLleno { get; internal set; }


        internal void Llenar(IBodega bodega)
        {
           if (bodega.Existencia(producto)>= cantidad)
            {
                SeLleno = true;
                int existenciaTotal = bodega.Existencia(producto) - cantidad;
                bodega.ActualizarExistencia(producto, existenciaTotal);
            }
        }
    }
}