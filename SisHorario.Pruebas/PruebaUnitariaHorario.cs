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
            var lo_ciclo = Ciclo.Registrar(1, "I Ciclo");
            var lo_planestudio = PlanEstudio.Registrar(1, "2016 - I", "Nuevo Plan Estudio", "ACTIVO");
            var lo_semestre = Semestre.Registrar(1, "2016-I", "2016", lo_planestudio, "ACTIVO");
            var lo_ambiente = Ambiente.Registrar(1, "Laboratorio A", "Laboratorio", 30);
            var lo_curso = Curso.Registrar(1, "SI-210", "Programación I", 2, 4, 6, 4, "SI-110", "Obligatorio", "blue", lo_planestudio, lo_ciclo);
            var lo_horario = Horario.Registrar(1, 30, "A", "Lunes", "2", lo_personal, lo_ciclo, lo_semestre, lo_ambiente, lo_curso);
            Assert.IsNotNull(lo_horario);
            Assert.IsTrue(lo_horario.CodigoHorario == 1);
        }
    }
}
