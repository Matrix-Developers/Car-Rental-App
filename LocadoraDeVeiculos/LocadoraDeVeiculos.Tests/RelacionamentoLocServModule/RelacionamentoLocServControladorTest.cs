using FluentAssertions;
using LocadoraDeVeiculos.Controladores.ClientesModule;
using LocadoraDeVeiculos.Controladores.FuncionarioModule;
using LocadoraDeVeiculos.Controladores.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Controladores.LocacaoModule;
using LocadoraDeVeiculos.Controladores.RelacionamentoLocServModule;
using LocadoraDeVeiculos.Controladores.ServicoModule;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Controladores.VeiculoModule;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.RelacionamentoLocServModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Tests.RelacionamentoLocServModule
{
    [TestClass]
    public class RelacionamentoLocServControladorTest
    {
        List<Servico> listServicos;

        ControladorRelacionamentoLocServ controladorRelacionamento = null;
        ControladorServico controladorServico = null;
        ControladorLocacao controladorLocacao = null;
        ControladorGrupoDeVeiculos controladorGrupoDeVeiculos = null;
        ControladorVeiculo controladorVeiculo = null;
        ControladorFuncionario controladorFuncionario = null;
        ControladorCliente controladorCliente = null;
        GrupoDeVeiculo grupoVeiculos;
        Veiculo veiculo;
        Funcionario funcionario;
        Cliente clienteContratante;
        Cliente clienteCondutor;
        Locacao locacao;
        Servico servico;
        RelacionamentoLocServ novoRelacionamento;

        public RelacionamentoLocServControladorTest()
        {
            listServicos = new List<Servico>();
            controladorRelacionamento = new ControladorRelacionamentoLocServ();
            controladorServico = new ControladorServico();
            controladorGrupoDeVeiculos = new ControladorGrupoDeVeiculos();
            controladorVeiculo = new ControladorVeiculo();
            controladorFuncionario = new ControladorFuncionario();
            controladorCliente = new ControladorCliente();
            controladorLocacao = new ControladorLocacao(controladorVeiculo, controladorFuncionario, controladorCliente);
            
            Db.Update("DELETE FROM [TBSERVICO_LOCACAO]");
            Db.Update("DELETE FROM [TBSERVICO]");
            Db.Update("DELETE FROM [TBLOCACAO]");
            Db.Update("DELETE FROM [TBVEICULO]");
            Db.Update("DELETE FROM [TBGRUPOVEICULO]");
            Db.Update("DELETE FROM [TBFUNCIONARIO]");
            Db.Update("DELETE FROM [TBCLIENTE]");
        }

        [TestMethod]
        public void DeveInserirUmRelacionamento()
        {
            //arrange
            InserirUmaLocacao();
            InserirUmServico();
            listServicos.Add(servico);

            //action
            novoRelacionamento = new RelacionamentoLocServ(0, locacao, listServicos);
            controladorRelacionamento.InserirNovo(novoRelacionamento);

            //assert
            var relacionamentoEncontrado = controladorRelacionamento.SelecionarPorId(novoRelacionamento.Id);
            relacionamentoEncontrado.Should().Be(novoRelacionamento);
        }

        #region Métodos Privados
        private void InserirUmServico()
        {
            servico = new Servico(0, "nome", true, 100);
            controladorServico.InserirNovo(servico);
        }
        private void InserirUmaLocacao()
        {
            grupoVeiculos = new GrupoDeVeiculo(0, "nome", 12.3f, 15.5f, 20.5f, 30, 16.3f, 45.2f);
            controladorGrupoDeVeiculos.InserirNovo(grupoVeiculos);
            veiculo = new Veiculo(0, "Ecosport", grupoVeiculos, "LPT-4652", "4DF56F78E8WE9WED", "Ford", "Prata", "Gasolina Comum", 60.5, 2018, 30000, 4, 5, 'G', true, true, true, true, null);
            controladorVeiculo.InserirNovo(veiculo);
            funcionario = new Funcionario(0, "Nome Teste", "954.746.736-04", "Endereco Funcionario", "4932518000", "teste@email.com", 001, "user acesso", "12345", new DateTime(2021, 01, 01), "Vendedor", 1000f, true);
            controladorFuncionario.InserirNovo(funcionario);
            clienteContratante = new Cliente(0, "Nome Teste", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            controladorCliente.InserirNovo(clienteContratante);
            clienteCondutor = new Cliente(0, "Nardolindo", "954.746.736-04", "Endereco Cliente", "4932518000", "teste@email.com", "978545956-90", new DateTime(2030, 01, 01), true);
            controladorCliente.InserirNovo(clienteCondutor);

            locacao = new Locacao(0, veiculo, funcionario, clienteContratante, clienteCondutor, DateTime.Today, DateTime.Today.AddDays(5f), DateTime.Today.AddDays(5f), "KmLivre", "Nenhum", 0, 0, false, null);
            controladorLocacao.InserirNovo(locacao);
        }
        #endregion
    }
}
