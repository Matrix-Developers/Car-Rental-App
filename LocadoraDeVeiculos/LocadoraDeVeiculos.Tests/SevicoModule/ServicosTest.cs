using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocadoraDeVeiculos.Dominio.SevicosModule;

namespace LocadoraDeVeiculos.Tests.SevicoModule
{

    [TestClass]
    public class ServicosTest
    {

        [TestMethod]
        public void DeveCriarServicoCorreto()
        {
            Servico servico = new Servico(0, "nome", "tipo", 100);
            Assert.AreEqual("VALIDO", servico.Validar());
        }

        [TestMethod]

        public void DeveCriarServicoIncorreto()
        {
            Servico servico = new Servico(0, "", "", 0);
            Assert.AreEqual("O nome não pode ser nulo\nO valor não pode ser nulo ou negativo", servico.Validar());
        }
    }
}
