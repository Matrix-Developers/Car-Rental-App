using Microsoft.VisualStudio.TestTools.UnitTesting;
using LocadoraDeVeiculos.Dominio.PessoaModule;
using System;

namespace LocadoraDeVeiculos.Tests.PessoaModule
{
    [TestClass]
    public class PessoaTest
    {
        [TestMethod]
        public void DeveCriarPessoaCorretoCompleto()
        {
            Pessoa pessoa = new Pessoa(1, "nome", "11111111111", "endereco", "999999999", "email@g.com", true);
            Assert.AreEqual("VALIDO", pessoa.Validar());
        }

        [TestMethod]
        public void DeveCriarPessoaCorretoSemTelefone()
        {
            Pessoa pessoa = new Pessoa(1, "nome", "11111111111", "endereco", "", "email@g.com", true);
            Assert.AreEqual("VALIDO", pessoa.Validar());
        }

        [TestMethod]
        public void DeveCriarPessoaCorretoSemEmail()
        {
            Pessoa pessoa = new Pessoa(1, "nome", "11111111111", "endereco", "999999999", "", true);
            Assert.AreEqual("VALIDO", pessoa.Validar());
        }

        [TestMethod]
        public void DeveCriarPessoaIncorreto()
        {
            Pessoa pessoa = new Pessoa(1, "", "", "", "", "", true);
            Assert.AreEqual("O nome não pode ser nulo\nO CPF/CNPJ não está correto\nO endereço não pode ser nulo\nÉ obrigatório inserir Telefone ou E-mail\n", pessoa.Validar());
        }
    }
}
