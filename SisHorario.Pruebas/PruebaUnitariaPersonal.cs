using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SisHorario.Dominio;

namespace SisHorario.Pruebas
{
    [TestClass]
    public class PruebaUnitariaPersonal
    {
        [TestMethod]
        public void PersonalCreadoSatisfactoriamente()
        {
            var lo_personal = Personal.Registrar(1, "Elard", "Rodríguez Marca", "Docente", "elard@hotmail.com", "Bolognesi 142", "406348", "952736484", "", "ACTIVO", "Contratado", "A");
            Assert.IsNotNull(lo_personal);
            Assert.IsTrue(lo_personal.CodigoPersonal == 1);
        }
    }
}
