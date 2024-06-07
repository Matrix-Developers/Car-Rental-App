using LocadoraDeVeiculos.Dominio.SevicosModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LocadoraDeVeiculos.UnitTests.SevicoModule
{

    [TestClass]
    public class ServicoDominioTest
    {

        [TestMethod]
        public void DeveCriarServicoCorreto()
        {
            Servico servico = new(0, "nome", true, 100f);
            Assert.AreEqual("VALID", servico.Validar());
        }

        [TestMethod]

        public void DeveCriarServicoIncorreto()
        {
            Servico servico = new(0, "", true, 0f);
            Assert.AreEqual("The name field cannot be null.\nThe value cannot be null.", servico.Validar());
        }
    }
}
