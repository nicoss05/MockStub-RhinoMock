using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RhinoMock
{
    [TestClass]
    public class TransporteTest
    {

        [TestMethod]
        public void SiElTransporteEstaLlenoLaMitadOMasPuedePartir()
        {
            var transporte = new Transporte();
            transporte.Capacidad = 1000;
            transporte.Cargar(400);

            var mercancia = new Mercancia();
            mercancia.Peso = 15;
            mercancia.Enviar(transporte);

            Assert.IsFalse(mercancia.SeEnvio);
        }
        [TestMethod]
        public void SiUnaCargaInicialMasElPesoNoEnvia()
        {
            var transporte = new Transporte();
            transporte.Capacidad = 400;
            transporte.Cargar(484);

            var mercancia = new Mercancia();
            mercancia.Peso = 15;
            mercancia.Enviar(transporte);

            Assert.IsFalse(mercancia.SeEnvio);
        }
        [TestMethod]
        public void SiElPEsoDelEnvioMasLaCargaExcedeLaCapacidadNoEnvia()
        {
            var transporte = new Transporte();
            transporte.Capacidad = 400;
            transporte.Cargar(484);

            var mercancia = new Mercancia();
            mercancia.Peso = 15;
            mercancia.Enviar(transporte);

            Assert.IsFalse(mercancia.SeEnvio);
        }
        [TestMethod]
        public void PruebaConUnaCargaInicialSeEnvia()
        {
            var transporte = new Transporte();
            transporte.Capacidad = 600;
            transporte.Cargar(484);

            var mercancia = new Mercancia();
            mercancia.Peso = 15;
            mercancia.Enviar(transporte);

            Assert.IsFalse(mercancia.SeEnvio);
        }
    }
}
