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
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / User: {UsuarioLogado} ", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaCliente.ObtemIdSelecionado();
            if (id == 0)
            {
                MessageBox.Show("Select at least one Client to edit.", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Cliente clienteSelecionado = clienteService.SelecionarEntidadePorId(id);

            ClientesForm tela = new("Edit Client")
            {
                Clientes = clienteSelecionado
            };

            if (tela.ShowDialog() == DialogResult.OK)
            {
                clienteService.EditarEntidade(id, tela.Clientes);

                CarregaGrid();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Client: '{tela.Clientes.Nome}' edited successfully.");
            }
        }
        public void ExcluirRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / User: {UsuarioLogado} ", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            int id = tabelaCliente.ObtemIdSelecionado();
            if (id == 0)
            {
                MessageBox.Show("Select a Client to Delete", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Cliente clienteSelecionado = clienteService.SelecionarEntidadePorId(id);

            if (MessageBox.Show($"Are you sure you want to Delete the Client: '{clienteSelecionado.Nome}' ?",
                "Delete Client", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                clienteService.ExcluirEntidade(id);
                CarregaGrid();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Client: '{clienteSelecionado.Nome}' deleted sucessfully.");
            }
        }
        public void InserirNovoRegistro()
        {
            Log.Logger.Information("{DataEHora} / {Feature} / Layer: {Layer} / User: {UsuarioLogado} ", DateTime.Now, this.ToString(), "Apresentação", TelaPrincipalForm.FuncionarioLogado);
            ClientesForm tela = new("Register Client");
            if (tela.ShowDialog() == DialogResult.OK)
            {
                clienteService.InserirEntidade(tela.Clientes);
                CarregaGrid();
                TelaPrincipalForm.Instancia.AtualizarRodape($"Client '{tela.Clientes.Nome}' added sucessfully;");
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
