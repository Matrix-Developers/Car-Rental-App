using LocadoraDeVeiculos.Dominio.VeiculoModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Veiculos
{
    public partial class TabelaVeiculoControl : UserControl
    {
        public TabelaVeiculoControl()
        {
            InitializeComponent();
            gridVeiculos.ConfigurarGridZebrado();
            gridVeiculos.ConfigurarGridSomenteLeitura();
            gridVeiculos.Columns.AddRange(ObterColunas());
        }
        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},
                new DataGridViewTextBoxColumn { DataPropertyName = "modelo", HeaderText = "Model"},
                new DataGridViewTextBoxColumn { DataPropertyName = "grupoVeiculos", HeaderText = "Grup"},
                new DataGridViewTextBoxColumn { DataPropertyName = "placa", HeaderText = "Sign"},
                new DataGridViewTextBoxColumn { DataPropertyName = "marca", HeaderText = "Brand"},
                new DataGridViewTextBoxColumn { DataPropertyName = "cor", HeaderText = "Colour"},
                new DataGridViewTextBoxColumn { DataPropertyName = "tipoCombustivel", HeaderText = "Fuel Type"},
                new DataGridViewTextBoxColumn { DataPropertyName = "ano", HeaderText = "Year"},
                new DataGridViewTextBoxColumn { DataPropertyName = "numeroPortas", HeaderText = "Num. of Doors"},
                new DataGridViewTextBoxColumn { DataPropertyName = "capacidadePessoas", HeaderText = "Num. of Seats"},
                new DataGridViewTextBoxColumn { DataPropertyName = "tamanhoPortaMala", HeaderText = "Trunk Size"}
           };

            return colunas;
        }
        public int ObtemIdSelecionado()
        {
            return gridVeiculos.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Veiculo> veiculos)
        {
            gridVeiculos.Rows.Clear();

            foreach (Veiculo veiculo in veiculos)
                gridVeiculos.Rows.Add(veiculo.Id, veiculo.modelo, veiculo.grupoVeiculos, veiculo.placa, veiculo.marca, veiculo.cor, veiculo.tipoCombustivel, veiculo.ano, veiculo.numeroPortas, veiculo.capacidadePessoas, veiculo.tamanhoPortaMala);
        }
    }
}
