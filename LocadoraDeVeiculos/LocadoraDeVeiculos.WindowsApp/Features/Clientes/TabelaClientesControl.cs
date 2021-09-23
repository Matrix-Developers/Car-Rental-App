using LocadoraDeVeiculos.Controladores.ClientesModule;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Clientes
{
    public partial class TabelaClientesControl : UserControl    //precisa retirar o repositorio e usar appService
    {
        private readonly ClienteRepository controladorCliente = null;
        public TabelaClientesControl()
        {
            controladorCliente = new ClienteRepository();
            InitializeComponent();
            gridClientes.ConfigurarGridZebrado();
            gridClientes.ConfigurarGridSomenteLeitura();
            gridClientes.Columns.AddRange(ObterColunas());
        }

        public static DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "RegistroUnico", HeaderText = "Registro"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Endereco", HeaderText = "Endereço"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Telefone", HeaderText = "Telefone"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Email", HeaderText = "Email"},

                new DataGridViewTextBoxColumn {DataPropertyName = "CNH", HeaderText = "CNH"},

                new DataGridViewTextBoxColumn {DataPropertyName = "ValidadeCnh", HeaderText = "Validade CHN"},

                new DataGridViewTextBoxColumn {DataPropertyName = "ehpessoafisica", HeaderText = "É pessoa física "}

           };

            return colunas;
        }
        public int ObtemIdSelecionado()
        {
            return gridClientes.SelecionarId<int>();
        }

        public void AtualizarRegistros()
        {
            var clientes = controladorCliente.SelecionarTodos();
            CarregarTabela(clientes);
        }

        private void CarregarTabela(List<Cliente> clientes)
        {
            gridClientes.DataSource = clientes;
        }

    }
}
