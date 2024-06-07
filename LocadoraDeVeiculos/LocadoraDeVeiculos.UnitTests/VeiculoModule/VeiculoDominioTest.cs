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
            Veiculo veiculo = new(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true, true);

            Assert.AreEqual("VALID", veiculo.Validar());

        }

        [TestMethod]
        public void DeveApresentarErroVeiculo_TotalmenteIncorreto()
        {
            Veiculo veiculo = new(0, "", null, "", "", "", "", "", 0, 0, 0, 0, 0, 'a', false, false, false, false);

            Assert.AreEqual("The model field cannot be empty.\nThe sign field cannot be empty.\nThe chassis field cannot be empty.\nThe brand field cannot be empty.\nThe color field cannot be empty.\nThe fuel type field cannot be empty.\nThe tank capacity field cannot be empty.\nThe year field cannot be empty.\nThe mileage field cannot be empty.\nThe number of doors field cannot be empty.\nThe number of seats field cannot be empty.\nThe trunk size field cannot be empty.\n",
                veiculo.Validar());
        }
    }
}
