﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SisHorario.Dominio;

namespace SisHorario.Pruebas
{
    [TestClass]
    public class PruebaUnitariaCurso
    {
        [TestMethod]
        public void CursoCreadoSatisfactoriamente()
        {
            var lo_planestudio = PlanEstudio.Registrar(1, "2016 - I", "Nuevo Plan Estudio", "ACTIVO");
            var lo_ciclo = Ciclo.Registrar(1, "I Ciclo");
            var lo_curso = Curso.Registrar(1, "SI-210", "Programación I", 2, 4, 6, 4, "SI-110", "Obligatorio", "blue", lo_planestudio, lo_ciclo);
            Assert.IsNotNull(lo_curso);
            Assert.IsTrue(lo_curso.CodigoCurso == 1);
        }
    }
}
