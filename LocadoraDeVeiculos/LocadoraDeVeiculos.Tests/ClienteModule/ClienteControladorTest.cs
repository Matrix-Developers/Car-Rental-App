using LocadoraDeVeiculos.Controladores.ClientesModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraDeVeiculos.Tests.ClienteModule
{
    [TestClass]
    [TestCategory("Controladores")]
    public class ClienteControladorTest
    {
        ControladorClientes controlador = null;

        public ControladorClientesTest()
        {
            controlador = new ControladorClientes();
         
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
