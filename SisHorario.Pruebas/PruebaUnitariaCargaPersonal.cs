using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SisHorario.Dominio;

namespace SisHorario.Pruebas
{
    [TestClass]
    public class PruebaUnitariaCargaPersonal
    {
        [TestMethod]
        public void CargaPersonalCreadoSatisfactoriamente()
        {
            var lo_cargapersonal = CargaPersonal.Registrar(1, "A", 1, 1, 1, 1);
            Assert.IsNotNull(lo_cargapersonal);
            Assert.IsTrue(lo_cargapersonal.CodigoCargaPersonal == 1);
        }
    }
}
