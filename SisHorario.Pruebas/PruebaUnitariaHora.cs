using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SisHorario.Dominio;

namespace SisHorario.Pruebas
{
    [TestClass]
    public class PruebaUnitariaHora
    {
        [TestMethod]
        public void HoraCreadaSatisfactoriamente()
        {
            var lo_hora = Hora.Registrar(1, "Laboratorio A");
            Assert.IsNotNull(lo_hora);
            Assert.IsTrue(lo_hora.CodigoHora == 1);
        }
    }
}
