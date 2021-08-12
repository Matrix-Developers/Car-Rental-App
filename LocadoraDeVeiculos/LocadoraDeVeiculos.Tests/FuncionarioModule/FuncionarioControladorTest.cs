using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocadoraDeVeiculos.Controladores.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;

namespace LocadoraDeVeiculos.Tests.FuncionarioModule
{
    [TestClass]
    class FuncionarioControladorTest
    {
        Funcionario funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", new DateTime(2021, 01, 01), "Vendedor", 1000f);
        ControladorFuncionario ctr = new ControladorFuncionario();

        [TestMethod]
        public void DeveInserirFuncionarioNoBanco()
        {
            ctr.InserirNovo(funcionario);
        }
    }
}
