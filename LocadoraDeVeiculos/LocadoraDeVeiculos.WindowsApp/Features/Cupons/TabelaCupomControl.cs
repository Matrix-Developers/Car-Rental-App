using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Cupons
{
    public partial class TabelaCupomControl : UserControl
    {
        public TabelaCupomControl()
        {
            InitializeComponent();
            gridCupons.ConfigurarGridZebrado();
            gridCupons.ConfigurarGridSomenteLeitura();
            gridCupons.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "ID"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Name"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Codigo", HeaderText = "Code"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Value"},
                new DataGridViewTextBoxColumn { DataPropertyName = "EhDescontoFixo", HeaderText = "Fixed Discount"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Validade", HeaderText = "Validitiy"},
                new DataGridViewTextBoxColumn { DataPropertyName = "QtdUtilizada", HeaderText = "Times utilized"},
           };

            return colunas;
        }

        internal void AtualizarRegistros(List<Cupom> cupons)
        {
            gridCupons.Rows.Clear();

            foreach (Cupom cupom in cupons)
                gridCupons.Rows.Add(cupom.Id, cupom.Nome, cupom.Codigo, cupom.Valor, cupom.EhDescontoFixo, cupom.Validade, cupom.QtdUtilizada);
        }

        internal int ObtemIdSelecionado()
        {
            return gridCupons.SelecionarId<int>();
        }
    }
}
