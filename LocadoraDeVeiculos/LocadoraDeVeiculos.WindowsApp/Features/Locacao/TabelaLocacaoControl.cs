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
                new DataGridViewTextBoxColumn { DataPropertyName = "id", HeaderText = "id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Veiculo", HeaderText = "Veiculo"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ClienteContratante", HeaderText = "Cliente"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Condutor", HeaderText = "Condutor"},

                new DataGridViewTextBoxColumn {DataPropertyName = "PrecoLocacao", HeaderText = "Valor Inicial"},

                new DataGridViewTextBoxColumn {DataPropertyName = "DataDeSaida", HeaderText = "Data de Locação"},

                new DataGridViewTextBoxColumn {DataPropertyName = "DataPrevistaDeChegada", HeaderText = "Devolução"}
           };

            return colunas;
        }

        public int ObtemidSelecionado()
        {
            return gridLocacao.Selecionarid<int>();
        }

        public void AtualizarRegistros(List<Locacao> locacoes)
        {
            gridLocacao.Rows.Clear();

            foreach (Locacao locacao in locacoes)
            {
                gridLocacao.Rows.Add(locacao.id, locacao.Veiculo, locacao.ClienteContratante, locacao.ClienteCondutor, locacao.PrecoLocacao,
                    locacao.DataDeSaida, locacao.DataPrevistaDeChegada);
            }
        }
    }
}
