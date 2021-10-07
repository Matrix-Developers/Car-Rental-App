using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Servicos
{
    public partial class TabelaServicoControl : UserControl
    {
        public TabelaServicoControl()
        {
            InitializeComponent();
            gridServicos.ConfigurarGridZebrado();
            gridServicos.ConfigurarGridSomenteLeitura();
            gridServicos.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "id", HeaderText = "id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "EhTaxadoDiario", HeaderText = "É taxado diário"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor"},
            };

            return colunas;
        }

        public int ObtemidSelecionado()
        {
            return gridServicos.Selecionarid<int>();
        }

        public void AtualizarRegistros(List<Servico> servicos)
        {
            gridServicos.Rows.Clear();

            foreach (Servico servico in servicos)
            {
                gridServicos.Rows.Add(servico.id, servico.Nome, servico.EhTaxadoDiario, servico.Valor);
            }
        }
    }
}