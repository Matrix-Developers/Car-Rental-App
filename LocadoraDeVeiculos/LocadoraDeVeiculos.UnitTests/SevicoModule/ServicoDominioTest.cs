using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocadoraDeVeiculos.Dominio.SevicosModule;

namespace LocadoraDeVeiculos.UnitTests.SevicoModule
{

    [TestClass]
    public class ServicoDominioTest
    {

        [TestMethod]
        public void DeveCriarServicoCorreto()
        {
            Servico servico = new Servico(0, "nome", true, 100f);
            Assert.AreEqual("VALIDO", servico.Validar());
        }

        [TestMethod]

        public void DeveCriarServicoIncorreto()
        {
            Servico servico = new Servico(0, "", true, 0f);
            Assert.AreEqual("O nome não pode ser nulo\nO valor não pode ser nulo", servico.Validar());
        }
    }
}
