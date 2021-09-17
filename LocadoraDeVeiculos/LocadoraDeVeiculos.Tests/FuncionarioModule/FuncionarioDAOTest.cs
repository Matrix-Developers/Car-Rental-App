using LocadoraDeVeiculos.Controladores.FuncionarioModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using System;
using LocadoraDeVeiculos.IntegrationTests.Shared;
using LocadoraDeVeiculos.TestDataBuilders;
using FluentAssertions;

namespace LocadoraDeVeiculos.IntegrationTests.FuncionarioModule
{
    [TestClass]
    [TestCategory("DAO")]
    public class FuncionarioDAOTest
    {
        #region atributos privados
        private FuncionarioRepository controlador;
        private Funcionario funcionario;

        private string joao;
        private string jose;

        private string cpf;
        private string cnpj;

        private string lages;
        private string florianopolis;

        private string celular;
        private string fixo;

        private string gmail;
        private string hotmail;

        private int matriculaInterna01;
        private int matriculaInterna02;

        private string jao;
        private string ze;

        private string jao123;
        private string ze123;

        private DateTime tresMesesAtras;
        private DateTime umAnoAtras;

        private string dev;
        private string vendedor;

        private double seiscentos;
        private double seisMil;
        #endregion

        [TestInitialize]
        public void Setup()
        {
            controlador = new FuncionarioRepository();

            ConfigurarNome();

            ConfigurarRegistroUnico();

            ConfigurarEndereco();

            ConfigurarTelefone();

            ConfigurarEmail();

            ConfigurarMatriculaInterna();

            ConfigurarUsuarioAcesso();

            ConfigurarSenha();

            ConfigurarDataAdmissao();

            ConfigurarCargo();

            ConfigurarSalario();
        }

        [TestCleanup]
        public void TearDown()
        {
            ResetarBanco.ResetarTabelas();
        }

        [TestMethod]
        public void DeveInserirFuncionarioNoBanco()
        {
            //arrange
            funcionario = new FuncionarioDataBuilder()
                .ComNome(joao)
                .ComRegistroUnico(cpf)
                .ComEndereco(lages)
                .ComTelefone(celular)
                .ComEmail(gmail)
                .ComMatriculaInterna(matriculaInterna01)
                .ComUsuarioAcesso(jao)
                .ComSenha(jao123)
                .ComDataAdmissao(umAnoAtras)
                .ComCargo(dev)
                .ComSalario(seiscentos)
                .ComEhPessoaFisica()
                .Build();

            //action
            controlador.InserirNovo(funcionario);

            //assert
            var funcionarioEncontrado = controlador.SelecionarPorId(funcionario.Id);
            funcionarioEncontrado.Should().Be(funcionario);
        }

        [TestMethod]
        public void DeveExcluirFuncionarioNoBanco()
        {
            //arrange
            funcionario = new FuncionarioDataBuilder()
                .ComNome(joao)
                .ComRegistroUnico(cpf)
                .ComEndereco(lages)
                .ComTelefone(celular)
                .ComEmail(gmail)
                .ComMatriculaInterna(matriculaInterna01)
                .ComUsuarioAcesso(jao)
                .ComSenha(jao123)
                .ComDataAdmissao(umAnoAtras)
                .ComCargo(dev)
                .ComSalario(seiscentos)
                .ComEhPessoaFisica()
                .Build();

            //action
            controlador.InserirNovo(funcionario);
            controlador.Excluir(funcionario.Id);

            //assert
            var funcionarioEncontrado = controlador.SelecionarPorId(funcionario.Id);
            funcionarioEncontrado.Should().BeNull();
        }

        [TestMethod]
        public void DeveEditarFuncionarioNoBanco()
        {
            //arrange
            funcionario = new FuncionarioDataBuilder()
                .ComNome(joao)
                .ComRegistroUnico(cpf)
                .ComEndereco(lages)
                .ComTelefone(celular)
                .ComEmail(gmail)
                .ComMatriculaInterna(matriculaInterna01)
                .ComUsuarioAcesso(jao)
                .ComSenha(jao123)
                .ComDataAdmissao(umAnoAtras)
                .ComCargo(dev)
                .ComSalario(seiscentos)
                .ComEhPessoaFisica()
                .Build(); 

            Funcionario funcionarioEditado = new FuncionarioDataBuilder()
                .ComNome(jose)
                .ComRegistroUnico(cpf)
                .ComEndereco(florianopolis)
                .ComTelefone(fixo)
                .ComEmail(hotmail)
                .ComMatriculaInterna(matriculaInterna02)
                .ComUsuarioAcesso(ze)
                .ComSenha(ze123)
                .ComDataAdmissao(tresMesesAtras)
                .ComCargo(vendedor)
                .ComSalario(seisMil)
                .ComEhPessoaFisica()
                .Build();

            //action
            controlador.InserirNovo(funcionario);
            controlador.Editar(funcionario.Id, funcionarioEditado);

            //acert
            var funcionarioAtualizado = controlador.SelecionarPorId(funcionario.Id);
            funcionarioAtualizado.Should().Be(funcionarioEditado);
        }

        [TestMethod]
        public void DeveSelecionarTodosFuncionarioNoBanco()
        {
            //arrange
            funcionario = new FuncionarioDataBuilder()
                .ComNome(joao)
                .ComRegistroUnico(cpf)
                .ComEndereco(lages)
                .ComTelefone(celular)
                .ComEmail(gmail)
                .ComMatriculaInterna(matriculaInterna01)
                .ComUsuarioAcesso(jao)
                .ComSenha(jao123)
                .ComDataAdmissao(umAnoAtras)
                .ComCargo(dev)
                .ComSalario(seiscentos)
                .ComEhPessoaFisica()
                .Build();

            Funcionario funcionario2 = new FuncionarioDataBuilder()
                .ComNome(jose)
                .ComRegistroUnico(cpf)
                .ComEndereco(florianopolis)
                .ComTelefone(fixo)
                .ComEmail(hotmail)
                .ComMatriculaInterna(matriculaInterna02)
                .ComUsuarioAcesso(ze)
                .ComSenha(ze123)
                .ComDataAdmissao(tresMesesAtras)
                .ComCargo(vendedor)
                .ComSalario(seisMil)
                .ComEhPessoaFisica()
                .Build();

            //action
            controlador.InserirNovo(funcionario);
            controlador.InserirNovo(funcionario2);
            var funcionarios = controlador.SelecionarTodos();

            //assert
            funcionarios.Should().HaveCount(2);
            funcionarios[0].Should().Be(funcionario);
            funcionarios[1].Should().Be(funcionario2);
        }

        #region Métodos privados
        private void ConfigurarNome()
        {
            joao = "João";
            jose = "José";
        }
        private void ConfigurarRegistroUnico()
        {
            cpf = "26520624098";
            cnpj = "54738501000107";
        }
        private void ConfigurarEndereco()
        {
            lages = "Centro, Lages - SC";
            florianopolis = "Centro, Florianópolis - SC";
        }
        private void ConfigurarTelefone()
        {
            celular = "(49) 99999-9999";
            fixo = "(49) 9999-9999";
        }
        private void ConfigurarEmail()
        {
            gmail = "email@gmail.com";
            hotmail = "email@hotmail.com";
        }
        private void ConfigurarMatriculaInterna()
        {
            matriculaInterna01 = 1;
            matriculaInterna02 = 2;
        }
        private void ConfigurarUsuarioAcesso()
        {
            jao = "jao";
            ze = "ze";
        }
        private void ConfigurarSenha()
        {
            jao123 = "jao123";
            ze123 = "ze123";
        }
        private void ConfigurarDataAdmissao()
        {
            umAnoAtras = DateTime.Today.AddYears(-1);
            tresMesesAtras = DateTime.Today.AddMonths(-3);
        }
        private void ConfigurarCargo()
        {
            dev = "dev";
            vendedor = "vendedor";
        }
        private void ConfigurarSalario()
        {
            seiscentos = 600;
            seisMil = 6000;
        }
        #endregion
    }
}
