using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GestionBancariaAppNS;

namespace GestionBancariaTestCBT2324
{
    [TestClass]
    public class GestionBancariatestCBT2324
    {
        [TestMethod] //CBT2324
        public void validarReintegro()
        {
            //preparacion del caso de prueba CBT2324
            double saldoInicial = 1000;
            double reintegro = 250;
            double saldoEsperado = 750;

            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);

            //metodo a probar
            miApp.RealizarReintegro(reintegro);

            //con Assert.AreEqual comprobamos que el valor saldoEsperado es igual a lo que
            //devuelve ObtenerSaldo(), si no es asi, la prueba no se superará
            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "se produjo un error");
        }

        [TestMethod]

        public void validarIngreso() 
        {
            double saldoInicial = 1000;
            double ingreso = 250;
            double saldoEsperado = 1250;

            GestionBancariaApp miApp = new GestionBancariaApp(saldoInicial);

            miApp.RealizarIngreso(ingreso);

            Assert.AreEqual(saldoEsperado, miApp.ObtenerSaldo(), 0.001, "se produjo un error");
        }
    }
}
