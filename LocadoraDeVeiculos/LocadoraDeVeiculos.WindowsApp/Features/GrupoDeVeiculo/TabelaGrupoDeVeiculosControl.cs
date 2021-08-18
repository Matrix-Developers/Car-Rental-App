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

namespace LocadoraDeVeiculos.WindowsApp.Features.GrupoDeVeiculo
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

                new DataGridViewTextBoxColumn { DataPropertyName = "", HeaderText = ""},

                new DataGridViewTextBoxColumn { DataPropertyName = "", HeaderText = ""},

                new DataGridViewTextBoxColumn { DataPropertyName = "", HeaderText = ""},

                new DataGridViewTextBoxColumn {DataPropertyName = "", HeaderText = ""},

                new DataGridViewTextBoxColumn {DataPropertyName = "", HeaderText = ""}
           };

            return colunas;
        }
        public int ObtemIdSelecionado()
        {
            return gridGrupoDeVeiculos.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<GrupoDeVeiculos> grupoDeVeiculos)
        {
            gridGrupoDeVeiculos.Rows.Clear();

            foreach (GrupoDeVeiculos grupo in grupoDeVeiculos)
            {
                gridGrupoDeVeiculos.Rows.Add(grupo.Id, grupo.Nome, grupo.TaxaPlanoDiario, grupo.TaxaKmControlado,
                    grupo.TaxaKmLivre);
            }
        }
    }
}