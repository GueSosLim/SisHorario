using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SisHorario.Dominio;

namespace SisHorario.Pruebas
{
    [TestClass]
    public class PruebaUnitariaCiclo
    {
        [TestMethod]
        public void CicloCreadoSatisfactoriamente()
        {
            var lo_ciclo = Ciclo.Registrar(1, "I Ciclo");
            Assert.IsNotNull(lo_ciclo);
            Assert.IsTrue(lo_ciclo.CodigoCiclo == 1);
        }
    }
}
