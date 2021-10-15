using LocadoraDeVeiculos.Aplicacao.ClienteModule;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Infra.Logs;
using LocadoraDeVeiculos.WindowsApp.Clientes;
using LocadoraDeVeiculos.WindowsApp.ClientesModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
using Serilog;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Clientes
{
    public class OperacoesClientes : ICadastravel
    {
        private readonly ClienteAppService clienteService;
        private readonly TabelaClientesControl tabelaCliente;

        public OperacoesClientes(ClienteAppService clienteService)
        {
            this.clienteService = clienteService;
            tabelaCliente = new TabelaClientesControl();
        }

        public void EditarRegistro()
        {
            GeradorLog.ConfigurarLog();
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / Usuário: {UsuarioLogado} ", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaCliente.ObtemIdSelecionado();
            if (id == 0)
            {
                MessageBox.Show("Selecione um cliente para editar", "Edição de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Cliente clienteSelecionado = clienteService.SelecionarEntidadePorId(id);

            ClientesForm tela = new("Edição de Clientes")
            {
                Clientes = clienteSelecionado
            };

            if (tela.ShowDialog() == DialogResult.OK)
            {
                clienteService.EditarEntidade(id, tela.Clientes);

                CarregaGrid();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Cliente: [{tela.Clientes.Nome}] editado com sucesso");
            }
        }
        public void ExcluirRegistro()
        {
            GeradorLog.ConfigurarLog();
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / Usuário: {UsuarioLogado} ", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaCliente.ObtemIdSelecionado();
            if (id == 0)
            {
                MessageBox.Show("Selecione um cliente para excluir", "Exclusão de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Cliente clienteSelecionado = clienteService.SelecionarEntidadePorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o cliente: [{clienteSelecionado.Nome}] ?",
                "Exclusão de Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                clienteService.ExcluirEntidade(id);
                CarregaGrid();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Cliente: [{clienteSelecionado.Nome}] removido com sucesso");
            }
        }
        public void InserirNovoRegistro()
        {
            GeradorLog.ConfigurarLog();
            Log.Logger.Information("{DataEHora} / {Feature} / Camada: {Camada} / Usuário: {UsuarioLogado} ", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            ClientesForm tela = new("Cadastro de Clientes");
            if (tela.ShowDialog() == DialogResult.OK)
            {
                clienteService.InserirEntidade(tela.Clientes);
                CarregaGrid();
                TelaPrincipalForm.Instancia.AtualizarRodape($"Cliente: [{tela.Clientes.Nome}] inserido com sucesso");
            }
        }

        private void CarregaGrid()
        {
            List<Cliente> listaClientes = clienteService.SelecionarTodasEntidade();
            tabelaCliente.AtualizarRegistros(listaClientes);
        }

        public UserControl ObterTabela()
        {
            List<Cliente> clientes = clienteService.SelecionarTodasEntidade();
            tabelaCliente.AtualizarRegistros(clientes);

            return tabelaCliente;
        }
        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }
    }
}
