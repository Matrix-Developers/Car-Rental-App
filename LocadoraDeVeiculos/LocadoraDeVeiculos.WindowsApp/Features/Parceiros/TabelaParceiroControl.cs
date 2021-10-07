using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Parceiros
{
    public partial class TabelaParceiroControl : UserControl
    {
        public TabelaParceiroControl()
        {
            InitializeComponent();
            gridParceiros.ConfigurarGridZebrado();
            gridParceiros.ConfigurarGridSomenteLeitura();
            gridParceiros.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "id", HeaderText = "ID"},
                new DataGridViewTextBoxColumn { DataPropertyName = "nome", HeaderText = "Nome"}
           };

            return colunas;
        }

        internal void AtualizarRegistros(List<Parceiro> parceiros)
        {
            gridParceiros.Rows.Clear();

            foreach (Parceiro parceiro in parceiros)
                gridParceiros.Rows.Add(parceiro.id, parceiro.Nome);

        }

        internal int ObtemidSelecionado()
        {
            return gridParceiros.Selecionarid<int>();
        }
    }
}
