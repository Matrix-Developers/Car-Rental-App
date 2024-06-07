using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Locacoes
{
    public partial class TabelaLocacaoControl : UserControl
    {
        public TabelaLocacaoControl()
        {
            InitializeComponent();
            gridLocacao.ConfigurarGridZebrado();
            gridLocacao.ConfigurarGridSomenteLeitura();
            gridLocacao.Columns.AddRange(ObterColunas());
        }
        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Veiculo", HeaderText = "Vehicle"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ClienteContratante", HeaderText = "Client"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Condutor", HeaderText = "Conductor"},

                new DataGridViewTextBoxColumn {DataPropertyName = "PrecoLocacao", HeaderText = "Initial Value"},

                new DataGridViewTextBoxColumn {DataPropertyName = "DataDeSaida", HeaderText = "Rental Date"},

                new DataGridViewTextBoxColumn {DataPropertyName = "DataPrevistaDeChegada", HeaderText = "Devolution Date"}
           };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridLocacao.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Locacao> locacoes)
        {
            gridLocacao.Rows.Clear();

            foreach (Locacao locacao in locacoes)
            {
                gridLocacao.Rows.Add(locacao.Id, locacao.Veiculo, locacao.ClienteContratante, locacao.ClienteCondutor, locacao.PrecoLocacao,
                    locacao.DataDeSaida, locacao.DataPrevistaDeChegada);
            }
        }
    }
}
