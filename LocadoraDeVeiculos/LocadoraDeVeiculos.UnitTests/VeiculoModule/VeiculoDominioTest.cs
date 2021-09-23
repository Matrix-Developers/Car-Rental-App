using LocadoraDeVeiculos.Dominio.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LocadoraDeVeiculos.UnitTests.VeiculoModule
{
    [TestClass]
    public class VeiculoTest
    {

        [TestMethod]
        public void DeveCriarVeiculo_Correto()
        {
            Veiculo veiculo = new(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true, true, null);

            Assert.AreEqual("VALIDO", veiculo.Validar());

        }

        [TestMethod]
        public void DeveApresentarErroVeiculo_TotalmenteIncorreto()
        {
            Veiculo veiculo = new(0, "", null, "", "", "", "", "", 0, 0, 0, 0, 0, 'a', false, false, false, false, null);

            Assert.AreEqual("O campo modelo não pode ser vazio!\nO campo placa não pode ser vazio!\nO campo chassi não pode ser vazio!\nO campo marca não pode ser vazio!\nO campo cor não pode ser vazio!\nO campo tipo de combústivel não pode ser vazio!\nO campo capacidade de tanque não pode ser vazio!\nO campo ano não pode ser vazio!\nO campo kilometragem não pode ser vazio!\nO campo numero de portas não pode ser vazio!\nO campo capacidades de pessoas não pode ser vazio!\nO campo tamanho do porta mala não pode ser vazio!\n",
                veiculo.Validar());
        }
    }
}
