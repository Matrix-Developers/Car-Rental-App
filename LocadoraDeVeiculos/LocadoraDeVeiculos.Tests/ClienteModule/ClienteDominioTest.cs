using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LocadoraDeVeiculos.Dominio.ClienteModule;

namespace LocadoraDeVeiculos.Tests.ClienteModule
{
    [TestClass]
    public class ClienteDominioTest
    {
        Cliente cliente;

        [TestMethod]
        public void DeveCriarClienteCorreto_CompletoPessoaFisica()
        {
            cliente = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);

            string resultadoValidaca = cliente.Validar();

            Assert.AreEqual("VALIDO", resultadoValidaca);
        }

        [TestMethod]
        public void DeveCriarClienteCorreto_CompletoPessoaJuridica()
        {
            cliente = new Cliente(0, "Nome Teste", "29.073.791/0001-61", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), false);

            string resultadoValidaca = cliente.Validar();

            Assert.AreEqual("VALIDO", resultadoValidaca);
        }

        [TestMethod]
        public void DeveCriarClienteCorreto_SemTelefone()
        {
            cliente = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);

            string resultadoValidaca = cliente.Validar();

            Assert.AreEqual("VALIDO", resultadoValidaca);
        }

        [TestMethod]
        public void DeveCriarClienteCorreto_SemEmail()
        {
            cliente = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "", "978545956-90", new DateTime(2030, 01, 01), true);

            string resultadoValidaca = cliente.Validar();

            Assert.AreEqual("VALIDO", resultadoValidaca);
        }

        [TestMethod]
        public void DeveApresentarErro_SemEmailETelefone()
        {
            cliente = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "", "", "978545956-90", new DateTime(2030, 01, 01), true);

            string resultadoValidaca = cliente.Validar();

            Assert.AreEqual("É obrigatório inserir Telefone ou E-mail\n", resultadoValidaca);
        }

        [TestMethod]
        public void DeveApresentarErro_PessoaFisica()
        {
            cliente = new Cliente(0, "", "", "", "", "", "", new DateTime(2000, 01, 01), true);

            string resultadoValidaca = cliente.Validar();

            Assert.AreEqual("CNH inválida\nCNH fora do prazo de validade\nO nome não pode ser nulo\nO endereço não pode ser nulo\nÉ obrigatório inserir Telefone ou E-mail\nO CPF não é válido\n", resultadoValidaca);
        }

        [TestMethod]
        public void DeveApresentarErro_PessoaFisicaSemCnh()
        {
            cliente = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "", new DateTime(2030, 01, 01), true);

            string resultadoValidaca = cliente.Validar();

            Assert.AreEqual("CNH inválida\n", resultadoValidaca);
        }

        [TestMethod]
        public void DeveApresentarErro_PessoaFisicaCnhComDataInvalida()
        {
            cliente = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2000, 01, 01), true);

            string resultadoValidaca = cliente.Validar();

            Assert.AreEqual("CNH fora do prazo de validade\n", resultadoValidaca);
        }

        [TestMethod]
        public void DeveApresentarErro_PessoaJuridica()
        {
            cliente = new Cliente(0, "", "", "", "", "", "", null, false);

            string resultadoValidaca = cliente.Validar();

            Assert.AreEqual("O nome não pode ser nulo\nO endereço não pode ser nulo\nÉ obrigatório inserir Telefone ou E-mail\nO CNPJ não é válido\n", resultadoValidaca);
        }

        #region Testes para as propriedades herdadas de Pessoa
        [TestMethod]
        public void DeveCriarPessoa_Completo()
        {
            cliente = new Cliente(1, "nome", "11111111111", "endereco", "999999999", "email@g.com", "978545956-90", new DateTime(2030, 01, 01), true);

            string resultado = cliente.Validar();

            Assert.AreEqual("VALIDO", resultado);
        }

        [TestMethod]
        public void DeveCriarPessoa_SemTelefone()
        {
            cliente = new Cliente(1, "nome", "11111111111", "endereco", "", "email@g.com", "978545956-90", new DateTime(2030, 01, 01), true);

            string resultado = cliente.Validar();

            Assert.AreEqual("VALIDO", resultado);
        }

        [TestMethod]
        public void DeveCriarPessoa_SemEmail()
        {
            cliente = new Cliente(1, "nome", "11111111111", "endereco", "999999999", "", "978545956-90", new DateTime(2030, 01, 01), true);

            string resultado = cliente.Validar();

            Assert.AreEqual("VALIDO", resultado);
        }

        [TestMethod]
        public void DeveApresentarErroPessoa_PessoaTotalmenteInvalida()
        {
            cliente = new Cliente(1, "", "", "", "", "", "978545956-90", new DateTime(2030, 01, 01), true);

            string resultado = cliente.Validar();

            Assert.AreEqual("O nome não pode ser nulo\nO endereço não pode ser nulo\nÉ obrigatório inserir Telefone ou E-mail\nO CPF não é válido\n", resultado);
        }

        [TestMethod]
        public void DeveApresentarErroPessoa_PessoaInvalidaComEmailSemArrobaEUmNumeroNoTelefone()
        {
            cliente = new Cliente(1, "", "", "", "1", "a", "978545956-90", new DateTime(2030, 01, 01), true);

            string resultado = cliente.Validar();

            Assert.AreEqual("O nome não pode ser nulo\nO endereço não pode ser nulo\nO telefone deve ter no mínimo 9 dígitos\nO email está incorreto\nO CPF não é válido\n", resultado);
        }

        [TestMethod]
        public void DeveApresentarErroPessoa_PessoaValidaComEmailSemArrobaTelefoneApenasUmNumero()
        {
            cliente = new Cliente(1, "nome", "11111111111", "endereco", "9", "email", "978545956-90", new DateTime(2030, 01, 01), true);

            string resultado = cliente.Validar();

            Assert.AreEqual("O telefone deve ter no mínimo 9 dígitos\nO email está incorreto\n", resultado);
        }

        [TestMethod]
        public void DeveApresentarErroPessoa_PessoaValidaApenasUmNumeroDeCelularApenas()
        {
            cliente = new Cliente(1, "nome", "11111111111", "endereco", "9", "email@email.com", "978545956-90", new DateTime(2030, 01, 01), true);

            string resultado = cliente.Validar();

            Assert.AreEqual("O telefone deve ter no mínimo 9 dígitos\n", resultado);
        }
        #endregion
    }
}
