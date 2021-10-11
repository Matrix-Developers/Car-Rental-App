using FluentAssertions;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.EntityFramework;
using LocadoraDeVeiculos.Infra.EntityFramework.Features;
using LocadoraDeVeiculos.TestDataBuilders;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.ORMTests.FuncionarioModule
{
    public class FuncionarioORMTest
    {
        #region atributos privados
        private IRepository<Funcionario> controlador;
        LocadoraDeVeiculosDBContext dbContext = new();
        private Funcionario funcionario;

        private string joao;
        private string jose;

        private string cpf;

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

        [SetUp]
        public void Setup()
        {
            LocadoraDeVeiculosDBContext dbContext = new();
            controlador = new FuncionarioORM(dbContext);

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

        [TearDown]
        public void TearDown()
        {
            var listaFuncionario = dbContext.Funcionarios.ToList().Select(x => x as Funcionario);
            foreach (var item in listaFuncionario)
                dbContext.Funcionarios.Remove(item);

            dbContext.SaveChanges();
        }

        [Test]
        public void DeveInserirFuncionario()
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
        [Test]
        public void DeveExcluirFuncionario()
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
        [Test]
        public void DeveEditarFuncionario()
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

            controlador.InserirNovo(funcionario);
            funcionario.Nome = jose;

            //action
            controlador.Editar(0, funcionario);

            //acert
            var funcionarioAtualizado = controlador.SelecionarPorId(funcionario.Id);
            funcionarioAtualizado.Nome.Should().Be("José");
        }
        [Test]
        public void DeveSelecionarTodosFuncionario()
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
