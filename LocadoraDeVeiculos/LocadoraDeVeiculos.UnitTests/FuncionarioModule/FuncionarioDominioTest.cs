using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LocadoraDeVeiculos.UnitTests.FuncionarioModule
{
    [TestClass]
    public class FuncionarioDominioTest
    {
        Funcionario funcionario;

        [TestMethod]
        public void DeveCriarFuncionario_Completo()
        {
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);

            string resultado = funcionario.Validar();

            Assert.AreEqual("VALID", resultado);
        }

        [TestMethod]
        public void DeveApresentarErroFuncionario_UsuarioDeAcessoEmBranco()
        {
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);

            string resultado = funcionario.Validar();

            Assert.AreEqual("O User de acesso não pode estar vazio\n", resultado);
        }

        [TestMethod]
        public void DeveApresentarErroFuncionario_MatriculaZerada()
        {
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 000, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);

            string resultado = funcionario.Validar();

            Assert.AreEqual("Matricula inválida\n", resultado);
        }

        [TestMethod]
        public void DeveApresentarErroFuncionario_SalarioZerado()
        {
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 0f, true);

            string resultado = funcionario.Validar();

            Assert.AreEqual("O salário deve ser maior que R$ 0,00\n", resultado);
        }

        [TestMethod]
        public void DeveApresentarErroFuncionario_CargoVazio()
        {
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "", 1000f, true);

            string resultado = funcionario.Validar();

            Assert.AreEqual("O funcionário deve possuir um cargo\n", resultado);
        }

        [TestMethod]
        public void DeveCriarFuncionario_DataDeAdmissaoInvalida()
        {
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2030, 01, 01), "Vendedor", 1000f, true);

            string resultado = funcionario.Validar();

            Assert.AreEqual("Data de admissão inválida\n", resultado);
        }

        [TestMethod]
        public void DeveApresentarErroFuncionario_FuncionarioTotalmenteInVALID()
        {
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 0, "", "12345", new DateTime(2030, 01, 01), "", 0f, true);

            string resultado = funcionario.Validar();

            Assert.AreEqual("O User de acesso não pode estar vazio\nMatricula inválida\nO salário deve ser maior que R$ 0,00\nO funcionário deve possuir um cargo\nData de admissão inválida\n", resultado);
        }

        #region Testes para as propriedades herdadas de Pessoa
        [TestMethod]
        public void DeveCriarPessoa_Completo()
        {
            funcionario = new Funcionario(1, "nome", "11111111111", "endereco", "999999999", "email@g.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);

            string resultado = funcionario.Validar();

            Assert.AreEqual("VALID", resultado);
        }

        [TestMethod]
        public void DeveCriarPessoa_SemTelefone()
        {
            funcionario = new Funcionario(1, "nome", "11111111111", "endereco", "", "email@g.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);

            string resultado = funcionario.Validar();

            Assert.AreEqual("VALID", resultado);
        }

        [TestMethod]
        public void DeveApresentarErroPessoa_PessoaTotalmenteInvalida()
        {
            funcionario = new Funcionario(1, "", "", "", "", "", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);

            string resultado = funcionario.Validar();

            Assert.AreEqual("The name field cannot be null.\nThe address field cannot be null.\nThe email field must be valid and not null.\nThe CPF field is not valid.\n", resultado);
        }

        [TestMethod]
        public void DeveApresentarErroPessoa_PessoaInvalidaComEmailSemArrobaEUmNumeroNoTelefone()
        {
            funcionario = new Funcionario(1, "", "", "", "1", "a", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);

            string resultado = funcionario.Validar();

            Assert.AreEqual("The name field cannot be null.\nThe address field cannot be null.\nThe email field must be valid and not null.\nThe CPF field is not valid.\n", resultado);
        }

        [TestMethod]
        public void DeveApresentarErroPessoa_PessoaValidaComEmailSemArrobaTelefoneApenasUmNumero()
        {
            funcionario = new Funcionario(1, "nome", "11111111111", "endereco", "9", "email", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);

            string resultado = funcionario.Validar();

            Assert.AreEqual("The email field must be valid and not null.\n", resultado);
        }

        [TestMethod]
        public void DeveApresentarErroPessoa_PessoaValidaApenasUmNumeroDeCelularApenas()
        {
            funcionario = new Funcionario(1, "nome", "11111111111", "endereco", "9", "email@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);

            string resultado = funcionario.Validar();

            Assert.AreEqual("VALID", resultado);
        }
        #endregion
    }
}
