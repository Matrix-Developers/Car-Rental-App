using LocadoraDeVeiculos.Controladores.ClientesModule;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.WindowsApp.Clientes;
using LocadoraDeVeiculos.WindowsApp.ClientesModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Clientes
{
    public class OperacoesClientes : ICadastravel
    {
        private readonly ClienteRepository controlador = null;
        private readonly TabelaClientesControl tabelaCliente = null;
        public OperacoesClientes (ClienteRepository ctrlCliente)
        {
            controlador = ctrlCliente;
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
            Cliente clienteSelecionado = controlador.SelecionarPorId(id);

            ClientesForm tela = new ClientesForm("Edição de Clientes");

            tela.Clientes = clienteSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Clientes);

                List<Cliente> contatos = controlador.SelecionarTodos();

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
            Cliente clienteSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o cliente: [{clienteSelecionado.Nome}] ?",
                "Exclusão de Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<Cliente> contatos = controlador.SelecionarTodos();

                tabelaCliente.AtualizarRegistros();

                TelaPrincipalForm.Instancia.AtualizarRodape($"Cliente: [{clienteSelecionado.Nome}] removido com sucesso");
            }
        }
        public void InserirNovoRegistro()
        {
            ClientesForm tela = new ClientesForm("Cadastro de Clientes");
            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Clientes);
                List<Cliente> clientes = controlador.SelecionarTodos();

                tabelaCliente.AtualizarRegistros();
                TelaPrincipalForm.Instancia.AtualizarRodape($"Cliente: [{tela.Clientes.Nome}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Cliente> contatos = controlador.SelecionarTodos();
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
