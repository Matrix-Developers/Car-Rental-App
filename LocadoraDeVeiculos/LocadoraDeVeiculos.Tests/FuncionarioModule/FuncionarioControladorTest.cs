using LocadoraDeVeiculos.Controladores.FuncionarioModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using System.Collections.Generic;
using System;
using LocadoraDeVeiculos.Tests.Shared;

namespace LocadoraDeVeiculos.Tests.FuncionarioModule
{
    [TestClass]
    public class FuncionarioControladorTest
    {
        Funcionario funcionario;
        Funcionario funcionario2;
        ControladorFuncionario ctr; 

        public FuncionarioControladorTest()
        {
            ctr = new ControladorFuncionario();
            ResetarBanco.ResetarTabelas();
        }

        [TestMethod]
        public void DeveInserirFuncionarioNoBanco()
        {
            //arrange
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);

            //action
            ctr.InserirNovo(funcionario);

            //assert
            Assert.AreEqual(funcionario,ctr.SelecionarPorId(funcionario.Id));
        }

        [TestMethod]
        public void DeveExcluirFuncionarioNoBanco()
        {
            //arrange
            funcionario = new Funcionario(0, "Nome Teste removido", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            
            //action
            ctr.InserirNovo(funcionario);
            ctr.Excluir(funcionario.Id);
            Funcionario funcionarioEncontrado = ctr.SelecionarPorId(funcionario.Id);

            //assert
            Assert.IsNull(funcionarioEncontrado);
        }

        [TestMethod]
        public void DeveEditarFuncionarioNoBanco()
        {
            //arrange
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            Funcionario funcionarioEditado = new Funcionario(0, "Nome Teste2", "954.746.736-04", "Endereco Funcionario2", "4932518000", "teste2@email.com", 001, "user2 acesso", "12345", new DateTime(2021, 01, 01), "Vendedor2", 1000f, true);

            //action
            ctr.InserirNovo(funcionario);
            ctr.Editar(funcionario.Id, funcionarioEditado);

            //acert
            Assert.AreEqual(funcionarioEditado,ctr.SelecionarPorId(funcionario.Id));
        }

        [TestMethod]
        public void DeveSelecionarTodosFuncionarioNoBanco()
        {
            //arrange
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            funcionario2 = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);

            //action
            ctr.InserirNovo(funcionario);
            ctr.InserirNovo(funcionario2);
            var lista = ctr.SelecionarTodos();

            //assert
            Assert.IsNotNull(lista);
        }
    }
}
