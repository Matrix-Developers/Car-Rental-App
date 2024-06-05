using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Devolucoes
{
    public partial class TabelaDevolucaoControl : UserControl
    {
        public TabelaDevolucaoControl()
        {
            InitializeComponent();
            gridDevolucoes.ConfigurarGridZebrado();
            gridDevolucoes.ConfigurarGridSomenteLeitura();
            gridDevolucoes.Columns.AddRange(ObterColunas());
        }
        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Modelo", HeaderText = "Model"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Placa", HeaderText = "Sign"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ClienteContratante", HeaderText = "Client"},

                new DataGridViewTextBoxColumn { DataPropertyName = "PrecoLocacao", HeaderText = "Initial Price"},

                new DataGridViewTextBoxColumn { DataPropertyName = "EstaAberta", HeaderText = "Is Open?"},

                new DataGridViewTextBoxColumn { DataPropertyName = "PrecoDevolucao", HeaderText = "Final Price"},

                new DataGridViewTextBoxColumn {DataPropertyName = "DataPrevistaDeChegada", HeaderText = "Devolution"}
           };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridDevolucoes.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Locacao> devolucoes)
        {
            gridDevolucoes.Rows.Clear();

            foreach (Locacao devolucao in devolucoes)
                gridDevolucoes.Rows.Add(devolucao.Id, devolucao.Veiculo.modelo, devolucao.Veiculo.placa, devolucao.ClienteContratante.Nome, devolucao.PrecoLocacao, devolucao.EstaAberta, devolucao.PrecoDevolucao, devolucao.DataPrevistaDeChegada);
        }
    }
}
