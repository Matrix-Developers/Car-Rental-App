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
                new DataGridViewTextBoxColumn { DataPropertyName = "id", HeaderText = "id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome do Grupo"},

                new DataGridViewTextBoxColumn { DataPropertyName = "TaxaPlanoDiario", HeaderText = "Taxa do Plano Diário"},

                new DataGridViewTextBoxColumn { DataPropertyName = "TaxaPorKmDiario", HeaderText = "Taxa por KM Diário"},

                new DataGridViewTextBoxColumn {DataPropertyName = "TaxaPlanoControlado", HeaderText = "Taxa do Plano Controlado"},

                new DataGridViewTextBoxColumn {DataPropertyName = "LimiteKmControlado", HeaderText = "Limites de KM Controlado"},

                new DataGridViewTextBoxColumn {DataPropertyName = "TaxaKmExcedidoControlado", HeaderText = "Taxa por KM Excedidos Controlado"},

                new DataGridViewTextBoxColumn {DataPropertyName = "TaxaPlanoLivre", HeaderText = "Taxa do Plano Livre"}
           };

            return colunas;
        }
        public int ObtemidSelecionado()
        {
            return gridGrupoDeVeiculos.Selecionarid<int>();
        }

        public void AtualizarRegistros(List<GrupoDeVeiculo> grupoDeVeiculos)
        {
            gridGrupoDeVeiculos.Rows.Clear();

            foreach (GrupoDeVeiculo grupo in grupoDeVeiculos)
            {
                gridGrupoDeVeiculos.Rows.Add(grupo.id, grupo.Nome, grupo.TaxaPlanoDiario, grupo.TaxaPorKmDiario, grupo.TaxaPlanoControlado,
                    grupo.LimiteKmControlado, grupo.TaxaKmExcedidoControlado, grupo.TaxaPlanoLivre);
            }
        }
    }
}