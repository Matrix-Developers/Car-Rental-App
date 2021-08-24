using FluentAssertions;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraDeVeiculos.Tests.LocacaoModule
{
    [TestClass]
    public class LocacaoDominioTest
    {
        [TestMethod]
        public void DeveCriarLocacao_ComContratantePFeCondutorPF()
        {
            Veiculo veiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, "30000", 4, 5, 'G', true, true, true);
            Funcionario funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            Cliente clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            Cliente clienteCondutor = new Cliente(1, "Arnaldo", "888.777.666.55", "Rua Laguna", "97777-6666", "arnaldo@test.com", "98765432103", new DateTime(2020, 11, 11), true);
            Locacao locacao = new Locacao(veiculo, funcionario, clienteContratante, clienteCondutor, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "Nenhum");

            string resultado = locacao.Validar();

            resultado.Should().Be("VALIDO");
        }

        [TestMethod]
        public void DeveCriarLocacao_ComContratantePFeSemCondutor()
        {
            Veiculo veiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, "30000", 4, 5, 'G', true, true, true);
            Funcionario funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            Cliente clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            Locacao locacao = new Locacao(veiculo, funcionario, clienteContratante, null, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "Nenhum");

            string resultado = locacao.Validar();

            resultado.Should().Be("VALIDO");
        }

        [TestMethod]
        public void DeveCriarLocacao_ComContratantePJeCondutorPF()
        {
            Veiculo veiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, "30000", 4, 5, 'G', true, true, true);
            Funcionario funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            Cliente clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), false);
            Cliente clienteCondutor = new Cliente(1, "Arnaldo", "888.777.666.55", "Rua Laguna", "97777-6666", "arnaldo@test.com", "98765432103", new DateTime(2020, 11, 11), true);
            Locacao locacao = new Locacao(veiculo, funcionario, clienteContratante, clienteCondutor, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "Nenhum");

            string resultado = locacao.Validar();

            resultado.Should().Be("VALIDO");
        }

        [TestMethod]
        public void DeveApresentarErro_ComVeiculoNulo()
        {
            Funcionario funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            Cliente clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            Cliente clienteCondutor = new Cliente(1, "Arnaldo", "888.777.666.55", "Rua Laguna", "97777-6666", "arnaldo@test.com", "98765432103", new DateTime(2020, 11, 11), true);
            Locacao locacao = new Locacao(null, funcionario, clienteContratante, clienteCondutor, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "Nenhum");

            string resultado = locacao.Validar();

            resultado.Should().Be("O veiculo não pode ser nulo\n");
        }

        [TestMethod]
        public void DeveApresentarErro_ComFuncionarioNull()
        {
            Veiculo veiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, "30000", 4, 5, 'G', true, true, true);
            Cliente clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            Cliente clienteCondutor = new Cliente(1, "Arnaldo", "888.777.666.55", "Rua Laguna", "97777-6666", "arnaldo@test.com", "98765432103", new DateTime(2020, 11, 11), true);
            Locacao locacao = new Locacao(veiculo, null, clienteContratante, clienteCondutor, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "Nenhum");

            string resultado = locacao.Validar();

            resultado.Should().Be("O funcionário locador não pode ser nulo\n");
        }

        [TestMethod]
        public void DeveApresentarErro_ComContratanteNullo()
        {
            Veiculo veiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, "30000", 4, 5, 'G', true, true, true);
            Funcionario funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            Cliente clienteCondutor = new Cliente(1, "Arnaldo", "888.777.666.55", "Rua Laguna", "97777-6666", "arnaldo@test.com", "98765432103", new DateTime(2020, 11, 11), true);
            Locacao locacao = new Locacao(veiculo, funcionario, null, clienteCondutor, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "Nenhum");

            string resultado = locacao.Validar();

            resultado.Should().Be("O cliente contratante não pode ser nulo\n");
        }

        [TestMethod]
        public void DeveApresentarErro_ComContratantePJsemCondutor()
        {
            Veiculo veiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, "30000", 4, 5, 'G', true, true, true);
            Funcionario funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            Cliente clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), false);
            Locacao locacao = new Locacao(veiculo, funcionario, clienteContratante, null, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "Nenhum");

            string resultado = locacao.Validar();

            resultado.Should().Be("O condutor não pode ser nulo quando o cliente contratante é pessoa juridica\n");
        }

        [TestMethod]
        public void DeveApresentarErro_ComContratantePJeCondutorPJ()
        {
            Veiculo veiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, "30000", 4, 5, 'G', true, true, true);
            Funcionario funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            Cliente clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), false);
            Cliente clienteCondutor = new Cliente(1, "Arnaldo", "888.777.666.55", "Rua Laguna", "97777-6666", "arnaldo@test.com", "98765432103", new DateTime(2020, 11, 11), false);
            Locacao locacao = new Locacao(veiculo, funcionario, clienteContratante, clienteCondutor, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "Nenhum");

            string resultado = locacao.Validar();

            resultado.Should().Be("O condutor não pode ser pessoa jurídica.\n");
        }

        [TestMethod]
        public void DeveApresentarErro_ComTipoDePlanoErrado()
        {
            Veiculo veiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, "30000", 4, 5, 'G', true, true, true);
            Funcionario funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            Cliente clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            Cliente clienteCondutor = new Cliente(1, "Arnaldo", "888.777.666.55", "Rua Laguna", "97777-6666", "arnaldo@test.com", "98765432103", new DateTime(2020, 11, 11), true);
            Locacao locacao = new Locacao(veiculo, funcionario, clienteContratante, clienteCondutor, DateTime.Today, DateTime.Today.AddDays(5f), "PlanoErrado", "Nenhum");

            string resultado = locacao.Validar();

            resultado.Should().Be("O tipo do plano é inválido.\n");
        }

        [TestMethod]
        public void DeveCriarLocacao_ComTipoDeSeguroErrado()
        {
            Veiculo veiculo = new Veiculo(0, "Ecosport", null, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, "30000", 4, 5, 'G', true, true, true);
            Funcionario funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            Cliente clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            Cliente clienteCondutor = new Cliente(1, "Arnaldo", "888.777.666.55", "Rua Laguna", "97777-6666", "arnaldo@test.com", "98765432103", new DateTime(2020, 11, 11), true);
            Locacao locacao = new Locacao(veiculo, funcionario, clienteContratante, clienteCondutor, DateTime.Today, DateTime.Today.AddDays(5f), "KmLivre", "SeguroErrado");

            string resultado = locacao.Validar();

            resultado.Should().Be("O tipo do seguro é inválido.\n");
        }
    }
}
