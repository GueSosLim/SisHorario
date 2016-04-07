using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SisHorario.Dominio;

namespace SisHorario.Pruebas
{
    [TestClass]
    public class PruebaUnitariaSemestre
    {
        [TestMethod]
        public void SemestreCreadoSatisfactoriamente()
        {
            var lo_planestudio = PlanEstudio.Registrar(1, "2016 - I", "Nuevo Plan Estudio", "ACTIVO");
            var lo_semestre = Semestre.Registrar(1, "2016-I", "2016", lo_planestudio, "ACTIVO");
            Assert.IsNotNull(lo_semestre);
            Assert.IsTrue(lo_semestre.CodigoSemestre == 1);
        }
    }
}
