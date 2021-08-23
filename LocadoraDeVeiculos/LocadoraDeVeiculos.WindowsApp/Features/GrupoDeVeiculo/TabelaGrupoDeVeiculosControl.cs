using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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