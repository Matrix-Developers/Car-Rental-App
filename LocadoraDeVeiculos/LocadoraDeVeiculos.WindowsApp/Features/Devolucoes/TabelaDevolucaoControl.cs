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

                new DataGridViewTextBoxColumn { DataPropertyName = "Modelo", HeaderText = "Modelo"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Placa", HeaderText = "Placa"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ClienteContratante", HeaderText = "Cliente"},

                new DataGridViewTextBoxColumn { DataPropertyName = "PrecoLocacao", HeaderText = "Preço Inicial"},

                new DataGridViewTextBoxColumn { DataPropertyName = "EstaAberta", HeaderText = "Locação Ativa"},

                new DataGridViewTextBoxColumn { DataPropertyName = "PrecoDevolucao", HeaderText = "Preço Final"},

                new DataGridViewTextBoxColumn {DataPropertyName = "DataPrevistaDeChegada", HeaderText = "Devolução"}
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
