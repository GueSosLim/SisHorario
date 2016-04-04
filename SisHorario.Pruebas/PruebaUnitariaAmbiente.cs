using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SisHorario.Dominio;

namespace SisHorario.Pruebas
{
    [TestClass]
    public class PruebaUnitariaAmbiente
    {
        [TestMethod]
        public void AmbienteCreadoSatisfactoriamente()
        {
            var lo_ambiente = Ambiente.Registrar(1, "Laboratorio A", "Laboratorio", 30);
            Assert.IsNotNull(lo_ambiente);
            Assert.IsTrue(lo_ambiente.CodigoAmbiente == 1);
        }
    }
}
