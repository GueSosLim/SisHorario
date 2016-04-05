using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SisHorario.Dominio;
using SisHorario.Infraestructura;

namespace SisHorario.Pruebas
{
    [TestClass]
    public class PruebasIntegralesAmbiente
    {
        [TestMethod]
        public void RegistrarAmbiente()
        {
            var lo_ambiente = Ambiente.Registrar(1, "Laboratorio A", "Laboratorio", 30);
            using (var lo_contexto = new SisHorarioContexto())
            {
                lo_contexto.Ambientes.Add(lo_ambiente);
                lo_contexto.SaveChanges();
            }
            Assert.IsTrue(lo_ambiente.CodigoAmbiente == 1);
        }
    }
}
