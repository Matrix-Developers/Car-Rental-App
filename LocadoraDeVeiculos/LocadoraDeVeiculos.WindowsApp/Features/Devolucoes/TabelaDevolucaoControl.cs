using LocadoraDeVeiculos.Dominio.LocacaoModule;
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Veiculo", HeaderText = "Veiculo"},

                new DataGridViewTextBoxColumn { DataPropertyName = "ClienteContratante", HeaderText = "Cliente"},

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
            {
                gridDevolucoes.Rows.Add(devolucao.Id, devolucao.Veiculo, devolucao.ClienteContratante, devolucao.DataPrevistaDeChegada);
            }
        }
    }
}
