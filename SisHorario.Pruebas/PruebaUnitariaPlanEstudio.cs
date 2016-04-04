using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SisHorario.Dominio;

namespace SisHorario.Pruebas
{
    [TestClass]
    public class PruebaUnitariaPlanEstudio
    {
        [TestMethod]
        public void PlanEstudioCreadoSatisfactoriamente()
        {
            var lo_planestudio = PlanEstudio.Registrar(1, "2016 - I", "Nuevo Plan Estudio", "ACTIVO");
            Assert.IsNotNull(lo_planestudio);
            Assert.IsTrue(lo_planestudio.CodigoPlanEstudio == 1);
        }
    }
}
