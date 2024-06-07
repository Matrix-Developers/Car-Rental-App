using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LocadoraDeVeiculos.UnitTests.ParceiroModule
{
    [TestClass]
    [TestCategory("Domínio")]
    public class ParceiroDominioTest
    {
        [TestMethod]
        public void DeveCriarParceiro_Correto()
        {
            //arrange
            Parceiro parceiro = new(0, "NDD");

            //action
            var resultadoValidacao = parceiro.Validar();

            //assert
            resultadoValidacao.Should().Be("VALID");
        }

        [TestMethod]
        public void DeveApresentarErro_NomeIncorreto()
        {
            //arrange
            Parceiro parceiro = new(0, "");

            //action
            var resultadoValidacao = parceiro.Validar();

            //assert
            resultadoValidacao.Should().Be("The name field cannot be null.");
        }
    }
}
