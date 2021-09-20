using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraDeVeiculos.UnitTests.LocacaoModule
{
    [TestClass]
    public class LocacaoDominioTest
    {
        Veiculo veiculo;
        Funcionario funcionario;
        Cliente clienteContratante;
        Cliente clienteCondutor;
        Locacao locacao;

        [TestMethod]
        public void DeveCriarLocacao_ComContratantePFeCondutorPF()
        {
            veiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true, true,null);
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            clienteCondutor = new Cliente(1, "Arnaldo", "888.777.666.55", "Rua Laguna", "97777-6666", "arnaldo@test.com", "98765432103", new DateTime(2020, 11, 11), true);
            locacao = new Locacao(0, veiculo, funcionario, clienteContratante, clienteCondutor, null, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "Nenhum",null);

            string resultado = locacao.Validar();

            resultado.Should().Be("VALIDO");
        }

        [TestMethod]
        public void DeveCriarLocacao_ComContratantePFeSemCondutor()
        {
            veiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true, true,null);
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            locacao = new Locacao(0, veiculo, funcionario, clienteContratante, null, null, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "Nenhum", null);

            string resultado = locacao.Validar();

            resultado.Should().Be("VALIDO");
        }

        [TestMethod]
        public void DeveCriarLocacao_ComContratantePJeCondutorPF()
        {
            veiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true, true,null);
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), false);
            clienteCondutor = new Cliente(1, "Arnaldo", "888.777.666.55", "Rua Laguna", "97777-6666", "arnaldo@test.com", "98765432103", new DateTime(2020, 11, 11), true);
            locacao = new Locacao(0, veiculo, funcionario, clienteContratante, clienteCondutor, null, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "Nenhum", null);

            string resultado = locacao.Validar();

            resultado.Should().Be("VALIDO");
        }

        [TestMethod]
        public void DeveApresentarErro_ComFuncionarioNull()
        {
            veiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true, true,null);
            clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            clienteCondutor = new Cliente(1, "Arnaldo", "888.777.666.55", "Rua Laguna", "97777-6666", "arnaldo@test.com", "98765432103", new DateTime(2020, 11, 11), true);
            locacao = new Locacao(0, veiculo, null, clienteContratante, clienteCondutor, null, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "Nenhum", null);

            string resultado = locacao.Validar();

            resultado.Should().Be("O funcionário locador não pode ser nulo\n");
        }

        [TestMethod]
        public void DeveApresentarErro_ComContratanteNullo()
        {
            veiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true,true, null);
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            clienteCondutor = new Cliente(1, "Arnaldo", "888.777.666.55", "Rua Laguna", "97777-6666", "arnaldo@test.com", "98765432103", new DateTime(2020, 11, 11), true);
            locacao = new Locacao(0, veiculo, funcionario, null, clienteCondutor, null, DateTime.Today, DateTime.Today.AddDays(5f), DateTime.Today.AddDays(5f), "KmLivre", "Nenhum",0,0,true, null);

            string resultado = locacao.Validar();

            resultado.Should().Be("O cliente contratante não pode ser nulo\n");
        }

        [TestMethod]
        public void DeveApresentarErro_ComContratantePJsemCondutor()
        {
            veiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true,true, null);
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), false);
            locacao = new Locacao(0, veiculo, funcionario, clienteContratante, null, null, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "Nenhum", null);

            string resultado = locacao.Validar();

            resultado.Should().Be("O condutor não pode ser nulo quando o cliente contratante é pessoa juridica\n");
        }

        [TestMethod]
        public void DeveApresentarErro_ComContratantePJeCondutorPJ()
        {
            veiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true,true, null);
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), false);
            clienteCondutor = new Cliente(1, "Arnaldo", "888.777.666.55", "Rua Laguna", "97777-6666", "arnaldo@test.com", "98765432103", new DateTime(2020, 11, 11), false);
            locacao = new Locacao(0, veiculo, funcionario, clienteContratante, clienteCondutor, null, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "Nenhum", null);

            string resultado = locacao.Validar();

            resultado.Should().Be("O condutor não pode ser pessoa jurídica.\n");
        }

        [TestMethod]
        public void DeveApresentarErro_ComTipoDePlanoErrado()
        {
            veiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true, true, null);
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            clienteCondutor = new Cliente(1, "Arnaldo", "888.777.666.55", "Rua Laguna", "97777-6666", "arnaldo@test.com", "98765432103", new DateTime(2020, 11, 11), true);
            locacao = new Locacao(0, veiculo, funcionario, clienteContratante, clienteCondutor, null, DateTime.Today, DateTime.Today.AddDays(5f), "PlanoErrado", "Nenhum", null);

            string resultado = locacao.Validar();

            resultado.Should().Be("O tipo do plano é inválido.\n");
        }

        [TestMethod]
        public void DeveCriarLocacao_ComTipoDeSeguroErrado()
        {
            veiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true, true, null);
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            clienteCondutor = new Cliente(1, "Arnaldo", "888.777.666.55", "Rua Laguna", "97777-6666", "arnaldo@test.com", "98765432103", new DateTime(2020, 11, 11), true);
            locacao = new Locacao(0, veiculo, funcionario, clienteContratante, clienteCondutor, null, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "SeguroErrado", null);

            string resultado = locacao.Validar();

            resultado.Should().Be("O tipo do seguro é inválido.\n");
        }
    }
}
