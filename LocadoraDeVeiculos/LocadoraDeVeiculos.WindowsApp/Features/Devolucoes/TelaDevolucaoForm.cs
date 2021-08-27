using LocadoraDeVeiculos.Dominio.LocacaoModule;
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
    public partial class TelaDevolucaoForm : Form
    {
        private Locacao devolucao;
        public TelaDevolucaoForm(string titulo)
        {
            InitializeComponent();
            lblTitulo.Text = titulo;
        }

        public Locacao Devolucao
        {
            get { return devolucao; }

            set
            {
                devolucao = value;

                //txtId.Text = devolucao.Id.ToString();
                //cBoxVeiculo.SelectedItem = devolucao.Veiculo;
                //cBoxFuncionario.SelectedItem = devolucao.FuncionarioLocador;
                //cBoxCliente.SelectedItem = devolucao.ClienteContratante;
                //cBoxCondutor.SelectedItem = devolucao.ClienteCondutor;
                //cBoxPlano.SelectedItem = devolucao.TipoDoPlano;
                //dateTPDataSaida.Text = devolucao.DataDeSaida.ToLongDateString();
                //dateTPDataDevolucao.Text = devolucao.DataPrevistaDeChegada.ToLongDateString();
            }
        }
    }
}
