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
            var lo_personal = Personal.Registrar(1, "Elard", "Rodríguez Marca", "Docente", "elard@hotmail.com", "Bolognesi 142", "406348", "952736484", "", "ACTIVO", "Contratado", "A");
            var lo_ciclo = Personal.Registrar();
            var lo_semestre = Personal.Registrar();
            var lo_personal = Personal.Registrar();
            var lo_personal = Personal.Registrar();
            var lo_horario = Horario.Registrar(1, 30, "A", "Lunes", "2", lo_personal, 1, 1, 1, 1);
            Assert.IsNotNull(lo_horario);
            Assert.IsTrue(lo_horario.CodigoHorario == 1);
        }
    }
}
