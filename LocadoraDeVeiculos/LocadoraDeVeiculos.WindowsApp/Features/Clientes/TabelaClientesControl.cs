using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Clientes
{
    public partial class TabelaClientesControl : UserControl    //precisa retirar o repositorio e usar appService
    {
        public TabelaClientesControl()
        {
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Name"},

                new DataGridViewTextBoxColumn { DataPropertyName = "RegistroUnico", HeaderText = "Code"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Endereco", HeaderText = "Address"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Telefone", HeaderText = "Phone"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Email", HeaderText = "Email"},

                new DataGridViewTextBoxColumn {DataPropertyName = "CNH", HeaderText = "CNH"},

                new DataGridViewTextBoxColumn {DataPropertyName = "ValidadeCnh", HeaderText = "CHN Validity"},

                new DataGridViewTextBoxColumn {DataPropertyName = "ehpessoafisica", HeaderText = "Is Natural Person? "}

           };

            return colunas;
        }
        public int ObtemIdSelecionado()
        {
            return gridClientes.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Cliente> clientes)
        {
            gridClientes.DataSource = null;
            CarregarTabela(clientes);
        }

        private void CarregarTabela(List<Cliente> clientes)
        {
            gridClientes.DataSource = clientes;
        }

    }
}
