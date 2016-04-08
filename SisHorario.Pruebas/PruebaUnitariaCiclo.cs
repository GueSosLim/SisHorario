using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SisHorario.Dominio;
using SisHorario.Arquitecturas.Repositorios;

namespace SisHorario.Pruebas
{
    [TestClass]
    public class PruebaUnitariaCiclo
    {
        [TestMethod]
        public void CicloCreadoSatisfactoriamente()
        {
            //var lo_ciclo = Ciclo.Registrar(1, "I Ciclo");
            //Assert.IsNotNull(lo_ciclo);
            //Assert.IsTrue(lo_ciclo.CodigoCiclo == 1);

            var lo_rep_ciclo = new RepositorioGenerico<Ciclo>();
            var lo_ciclos = lo_rep_ciclo.ObtenerPorExpresion(p => p.NombreCiclo == "II Ciclo");
            Assert.IsTrue(lo_ciclos.Count == 1);
        }
    }
}
