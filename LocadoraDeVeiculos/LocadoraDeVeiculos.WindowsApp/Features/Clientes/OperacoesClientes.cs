using LocadoraDeVeiculos.Aplicacao.ClienteModule;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.WindowsApp.Clientes;
using LocadoraDeVeiculos.WindowsApp.ClientesModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Clientes
{
    public class OperacoesClientes : ICadastravel
    {
        private readonly ClienteAppService ClienteService = null;
        private readonly TabelaClientesControl tabelaCliente = null;
        public OperacoesClientes(ClienteAppService clienteService)
        {
            ClienteService = clienteService;
            tabelaCliente = new TabelaClientesControl();
        }


        public void EditarRegistro()
        {
            int id = tabelaCliente.ObtemIdSelecionado();
            if (id == 0)
            {
                MessageBox.Show("Selecione um cliente para editar", "Edição de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Cliente clienteSelecionado = ClienteService.SelecionarClientePorId(id);

            ClientesForm tela = new("Edição de Clientes")
            {
                Clientes = clienteSelecionado
            };

            if (tela.ShowDialog() == DialogResult.OK)
            {
                ClienteService.EditarCliente(id, tela.Clientes);

                tabelaCliente.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Cliente: [{tela.Clientes.Nome}] editado com sucesso");
            }
        }
        public void ExcluirRegistro()
        {
            int id = tabelaCliente.ObtemIdSelecionado();
            if (id == 0)
            {
                MessageBox.Show("Selecione um cliente para excluir", "Exclusão de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Cliente clienteSelecionado = ClienteService.SelecionarClientePorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o cliente: [{clienteSelecionado.Nome}] ?",
                "Exclusão de Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ClienteService.ExcluirCliente(id);

                tabelaCliente.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Cliente: [{clienteSelecionado.Nome}] removido com sucesso");
            }
        }
        public void InserirNovoRegistro()
        {
            ClientesForm tela = new("Cadastro de Clientes");
            if (tela.ShowDialog() == DialogResult.OK)
            {
                ClienteService.InserirNovoCliente(tela.Clientes);

                tabelaCliente.AtualizarRegistros();
                TelaPrincipalForm.Instancia.AtualizarRodape($"Cliente: [{tela.Clientes.Nome}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            tabelaCliente.AtualizarRegistros();

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
