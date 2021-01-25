using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace RhinoMock
{
    [TestClass]
    public class TransporteMock
    {
        [TestMethod]
        public void SiElTransporteEstaLlenoLaMitadOMasPuedePartirMock()
        {
            var transporte = MockRepository.GenerateStub<ITransporte>();
            transporte.Stub(t => t.PorcentajeCarga()).Return(0.5);

            var mercancia = new Mercancia();
            mercancia.Peso = 15;
            mercancia.Enviar(transporte);

            Assert.IsTrue(mercancia.SeEnvio);
            transporte.AssertWasCalled(t => t.PorcentajeCarga());
            transporte.AssertWasCalled(t => t.Cargar(mercancia.Peso));
        }
        [TestMethod]
        public void SiUnaCargaInicialMasElPesoNoEnviaMock()
        {
            var transporte = MockRepository.GenerateStub<ITransporte>();
            transporte.Stub(t => t.PorcentajeCarga()).Return(0.5);

            transporte.Capacidad = 400;
            transporte.Cargar(484);

            var mercancia = new Mercancia();
            mercancia.Peso = 15;
            mercancia.Enviar(transporte);

            Assert.IsTrue(mercancia.SeEnvio);
            transporte.AssertWasCalled(t => t.PorcentajeCarga());
            transporte.AssertWasCalled(t => t.Cargar(mercancia.Peso));
        }
        [TestMethod]
        public void SiElPEsoDelEnvioMasLaCargaExcedeLaCapacidadNoEnviaMock()
        {
            var transporte = MockRepository.GenerateStub<ITransporte>();
            transporte.Stub(t => t.PorcentajeCarga()).Return(0.5);

            transporte.Capacidad = 400;
            transporte.Cargar(484);

            var mercancia = new Mercancia();
            mercancia.Peso = 15;
            mercancia.Enviar(transporte);

            Assert.IsTrue(mercancia.SeEnvio);
            transporte.AssertWasCalled(t => t.PorcentajeCarga());
            transporte.AssertWasCalled(t => t.Cargar(mercancia.Peso));
        }
        [TestMethod]
        public void PruebaConUnaCargaInicialSeEnviaMock()
        {
            var transporte = MockRepository.GenerateStub<ITransporte>();
            transporte.Stub(t => t.PorcentajeCarga()).Return(0.5);

            transporte.Capacidad = 600;
            transporte.Cargar(484);

            var mercancia = new Mercancia();
            mercancia.Peso = 15;
            mercancia.Enviar(transporte);

            Assert.IsTrue(mercancia.SeEnvio);
            transporte.AssertWasCalled(t => t.PorcentajeCarga());
            transporte.AssertWasCalled(t => t.Cargar(mercancia.Peso));
        }
    }
}
