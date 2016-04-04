using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SisHorario.Dominio;

namespace SisHorario.Pruebas
{
    [TestClass]
    public class PruebaUnitariaDisponibilidadPersonal
    {
        [TestMethod]
        public void DisponibilidadPersonalCreadoSatisfactoriamente()
        {
            var lo_disponibilidadpersonal = DisponibilidadPersonal.Registrar(1, "Lunes", 1, 1, 1);
            Assert.IsNotNull(lo_disponibilidadpersonal);
            Assert.IsTrue(lo_disponibilidadpersonal.CodigoDisponibilidadPersonal == 1);
        }
    }
}
