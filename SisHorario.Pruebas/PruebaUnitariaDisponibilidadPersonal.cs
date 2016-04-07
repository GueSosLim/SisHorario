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
            var lo_personal = Personal.Registrar(1, "Elard", "Rodríguez Marca", "Docente", "elard@hotmail.com", "Bolognesi 142", "406348", "952736484", "", "ACTIVO", "Contratado", "A");
            var lo_planestudio = PlanEstudio.Registrar(1, "2016 - I", "Nuevo Plan Estudio", "ACTIVO");
            var lo_semestre = Semestre.Registrar(1, "2016-I", "2016", lo_planestudio, "ACTIVO");
            var lo_hora = Hora.Registrar(1, "Laboratorio A");
            var lo_disponibilidadpersonal = DisponibilidadPersonal.Registrar(1, "Lunes", lo_personal, lo_hora, lo_semestre);
            Assert.IsNotNull(lo_disponibilidadpersonal);
            Assert.IsTrue(lo_disponibilidadpersonal.CodigoDisponibilidadPersonal == 1);
        }
    }
}
