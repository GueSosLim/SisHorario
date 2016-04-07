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
            var lo_personal = Personal.Registrar(1, "Elard", "Rodríguez Marca", "Docente", "elard@hotmail.com", "Bolognesi 142", "406348", "952736484", "", "ACTIVO", "Contratado", "A");
            var lo_ciclo = Ciclo.Registrar(1, "I Ciclo");
            var lo_planestudio = PlanEstudio.Registrar(1, "2016 - I", "Nuevo Plan Estudio", "ACTIVO");
            var lo_semestre = Semestre.Registrar(1, "2016-I", "2016", lo_planestudio, "ACTIVO");
            var lo_curso = Curso.Registrar(1, "SI-210", "Programación I", 2, 4, 6, 4, "SI-110", "Obligatorio", "blue", lo_planestudio, lo_ciclo);
            var lo_cargapersonal = CargaPersonal.Registrar(1, "A", lo_personal, lo_semestre, lo_ciclo, lo_curso);
            Assert.IsNotNull(lo_cargapersonal);
            Assert.IsTrue(lo_cargapersonal.CodigoCargaPersonal == 1);
        }
    }
}
