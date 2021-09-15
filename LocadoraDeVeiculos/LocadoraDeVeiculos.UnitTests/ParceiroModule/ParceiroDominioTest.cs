using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Parceiro parceiro = new Parceiro(0, "NDD");

            //action
            var resultadoValidacao = parceiro.Validar();

            //assert
            resultadoValidacao.Should().Be("VALIDO");
        }

        [TestMethod]
        public void DeveApresentarErro_NomeIncorreto()
        {
            //arrange
            Parceiro parceiro = new Parceiro(0, "");

            //action
            var resultadoValidacao = parceiro.Validar();

            //assert
            resultadoValidacao.Should().Be("O campo nome é obrigatório");
        }
    }
}
