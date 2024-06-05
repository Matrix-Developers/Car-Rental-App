using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.GrupoDeVeiculos
{
    public partial class TabelaGrupoDeVeiculosControl : UserControl
    {
        public TabelaGrupoDeVeiculosControl()
        {
            InitializeComponent();
            gridGrupoDeVeiculos.ConfigurarGridZebrado();
            gridGrupoDeVeiculos.ConfigurarGridSomenteLeitura();
            gridGrupoDeVeiculos.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Group Name"},

                new DataGridViewTextBoxColumn { DataPropertyName = "TaxaPlanoDiario", HeaderText = "Daily Plan Tax"},

                new DataGridViewTextBoxColumn { DataPropertyName = "TaxaPorKmDiario", HeaderText = "Tax per KM of Daily Plan"},

                new DataGridViewTextBoxColumn {DataPropertyName = "TaxaPlanoControlado", HeaderText = "Daily Controlled Plan Tax"},

                new DataGridViewTextBoxColumn {DataPropertyName = "LimiteKmControlado", HeaderText = "Controlled KM Limit"},

                new DataGridViewTextBoxColumn {DataPropertyName = "TaxaKmExcedidoControlado", HeaderText = "Tax per Exceeded KM controled"},

                new DataGridViewTextBoxColumn {DataPropertyName = "TaxaPlanoLivre", HeaderText = "Tax Free Plan"}
           };

            return colunas;
        }
        public int ObtemIdSelecionado()
        {
            return gridGrupoDeVeiculos.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<GrupoDeVeiculo> grupoDeVeiculos)
        {
            gridGrupoDeVeiculos.Rows.Clear();

            foreach (GrupoDeVeiculo grupo in grupoDeVeiculos)
            {
                gridGrupoDeVeiculos.Rows.Add(grupo.Id, grupo.Nome, grupo.TaxaPlanoDiario, grupo.TaxaPorKmDiario, grupo.TaxaPlanoControlado,
                    grupo.LimiteKmControlado, grupo.TaxaKmExcedidoControlado, grupo.TaxaPlanoLivre);
            }
        }
    }
}