using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LocadoraDeVeiculos.UnitTests.GrupoDeVeiculosModule
{
    [TestClass]
    public class GrupoDeVeiculosDominioTest
    {
        [TestMethod]
        public void DeveCriarGrupoDeVeiculo_Correto()
        {
            GrupoDeVeiculo grupoDeVeiculos = new(0, "nome", 12.3f, 15.5f, 20.5f, 30, 16.3f, 45.2f);

            string resultado = grupoDeVeiculos.Validar();

            Assert.AreEqual("VALID", resultado);
        }

        [TestMethod]
        public void DeveApresentarErro_GrupoTotalmenteIncorreto()
        {
            GrupoDeVeiculo grupoDeVeiculos = new(0, "", 0f, 0f, 0f, 0, 0f, 0f);

            string resultado = grupoDeVeiculos.Validar();
            //testes com todas as mensagens de invalidez são complicados para dar manutencao. talvez vale a pena mudarmos o modelo.
            Assert.AreEqual("The name field cannot be null.\nThe daily rate for the Daily Plan cannot be zero.\nThe rate per KM of the Daily Plan cannot be zero.\nThe daily rate of the Controlled Plan cannot be zero.\nThe KM limit of the Controlled plan cannot be zero.\nThe Controlled plan's Exceeded KM rate cannot be zero.\nThe daily fee for the Free Plan cannot be zero.\n",
                            resultado);
        }

        [TestMethod]
        public void DeveApresentarErro_SomenteNomeCorreto()
        {
            GrupoDeVeiculo grupoDeVeiculos = new(0, "nome", 0f, 0f, 0f, 0, 0f, 0f);

            string resultado = grupoDeVeiculos.Validar();
            //testes com todas as mensagens de invalidez são complicados para dar manutencao. talvez vale a pena mudarmos o modelo.
            Assert.AreEqual("The daily rate for the Daily Plan cannot be zero.\nThe rate per KM of the Daily Plan cannot be zero.\nThe daily rate of the Controlled Plan cannot be zero.\nThe KM limit of the Controlled plan cannot be zero.\nThe Controlled plan's Exceeded KM rate cannot be zero.\nThe daily fee for the Free Plan cannot be zero.\n",
                            resultado);
        }

        [TestMethod]
        public void DeveApresentarErro_SomenteNomeIncorreto()
        {
            GrupoDeVeiculo grupoDeVeiculos = new(0, "", 10f, 10f, 10f, 10, 10f, 10f);

            string resultado = grupoDeVeiculos.Validar();

            Assert.AreEqual("The name field cannot be null.\n",
                            resultado);
        }
    }
}
