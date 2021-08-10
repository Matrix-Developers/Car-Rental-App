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
        public void DeveCriarClienteCorreto_Completo()
        {
            cliente = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);

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
        public void DeveCriarClienteCorreto_SemEmailETelefone()
        {
            cliente = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "", "", "978545956-90", new DateTime(2030, 01, 01), true);

            string resultadoValidaca = cliente.Validar();

            Assert.AreEqual("É obrigatório inserir Telefone ou E-mail\n", resultadoValidaca);
        }

        [TestMethod]
        public void DeveCriarClienteIncorreto_PessoaFisica()
        {
            cliente = new Cliente(0, "", "", "", "", "", "", new DateTime(2000, 01, 01), true);

            string resultadoValidaca = cliente.Validar();

            Assert.AreEqual("CNH inválida\nCNH fora do prazo de validade\nO nome não pode ser nulo\nO endereço não pode ser nulo\nÉ obrigatório inserir Telefone ou E-mail\nO CPF não é válido\n", resultadoValidaca);
        }

        [TestMethod]
        public void DeveCriarClienteIncorreto_PessoaJuridico()
        {
            cliente = new Cliente(0, "", "", "", "", "", "", new DateTime(2000, 01, 01), false);

            string resultadoValidaca = cliente.Validar();

            Assert.AreEqual("CNH inválida\nCNH fora do prazo de validade\nO nome não pode ser nulo\nO endereço não pode ser nulo\nÉ obrigatório inserir Telefone ou E-mail\nO CNPJ não é válido\n", resultadoValidaca);
        }
    }
}
