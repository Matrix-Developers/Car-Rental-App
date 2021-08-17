using LocadoraDeVeiculos.Dominio.SevicosModule;
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
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Tipo", HeaderText = "Tipo"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor"},
            };

            return colunas;
        }

        public int ObtemIdSelecionado()
        {
            return gridServicos.SelecionarId<int>();
        }

        public void AtualizarRegistros(List<Servico> servicos)
        {
            gridServicos.Rows.Clear();

            foreach (Servico servico in servicos)
            {
                gridServicos.Rows.Add(servico.Id, servico.Nome, servico.Tipo, servico.Valor);
            }
        }
    }
}