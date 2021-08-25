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
                new DataGridViewTextBoxColumn { DataPropertyName = "modelo", HeaderText = "Modelo"},
                new DataGridViewTextBoxColumn { DataPropertyName = "grupoVeiculos", HeaderText = "Grupo"},
                new DataGridViewTextBoxColumn { DataPropertyName = "placa", HeaderText = "Placa"},
                new DataGridViewTextBoxColumn { DataPropertyName = "marca", HeaderText = "Marca"},
                new DataGridViewTextBoxColumn { DataPropertyName = "cor", HeaderText = "Cor"},
                new DataGridViewTextBoxColumn { DataPropertyName = "tipoCombustivel", HeaderText = "Combustivel"},
                new DataGridViewTextBoxColumn { DataPropertyName = "ano", HeaderText = "Ano"},
                new DataGridViewTextBoxColumn { DataPropertyName = "numeroPortas", HeaderText = "Qtd. Portas"},
                new DataGridViewTextBoxColumn { DataPropertyName = "capacidadePessoas", HeaderText = "Cap. Pessoas"},
                new DataGridViewTextBoxColumn { DataPropertyName = "tamanhoPortaMala", HeaderText = "Tam. Porta Malas"}
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
