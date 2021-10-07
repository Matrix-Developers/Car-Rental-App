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
                new DataGridViewTextBoxColumn { DataPropertyName = "id", HeaderText = "ID"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Codigo", HeaderText = "Codigo"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor"},
                new DataGridViewTextBoxColumn { DataPropertyName = "EhDescontoFixo", HeaderText = "Desconto Fixo"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Validade", HeaderText = "Validade"},
                new DataGridViewTextBoxColumn { DataPropertyName = "QtdUtilizada", HeaderText = "Vezes Utilizado"},
           };

            return colunas;
        }

        internal void AtualizarRegistros(List<Cupom> cupons)
        {
            gridCupons.Rows.Clear();

            foreach (Cupom cupom in cupons)
                gridCupons.Rows.Add(cupom.id, cupom.Nome, cupom.Codigo, cupom.Valor, cupom.EhDescontoFixo, cupom.Validade, cupom.QtdUtilizada);
        }

        internal int ObtemidSelecionado()
        {
            return gridCupons.Selecionarid<int>();
        }
    }
}
