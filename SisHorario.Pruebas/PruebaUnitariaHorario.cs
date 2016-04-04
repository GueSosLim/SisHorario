using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SisHorario.Dominio;

namespace SisHorario.Pruebas
{
    [TestClass]
    public class PruebaUnitariaHorario
    {
        [TestMethod]
        public void HorarioCreadoSatisfactoriamente()
        {
            var lo_horario = Horario.Registrar(1, 30, "A", "Lunes", "2", 1, 1, 1, 1, 1);
            Assert.IsNotNull(lo_horario);
            Assert.IsTrue(lo_horario.CodigoHorario == 1);
        }
    }
}
