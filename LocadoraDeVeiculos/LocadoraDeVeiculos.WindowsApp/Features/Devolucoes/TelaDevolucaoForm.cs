using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.WindowsApp.Servicos;
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
        List<Servico> adicionarSevicos = new List<Servico>();
        ServicosForm telaServico = new ServicosForm();
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

                txtId.Text = devolucao.Id.ToString();
                txtKmInicial.Text = devolucao.Veiculo.quilometragem.ToString();
                txtVeiculo.Text = devolucao.Veiculo.ToString();
                txtFuncionario.Text = devolucao.ToString();
                txtCliente.Text = devolucao.ToString();
                txtCondutor.Text = devolucao.ToString();
                txtPlano.Text = devolucao.TipoDoPlano;
                txtDataLocacao.Text = devolucao.DataDeSaida.ToLongDateString();
                txtDataDevolucao.Text = devolucao.DataPrevistaDeChegada.ToLongDateString();
            }
        }

        private void btnSelecionarServicos_Click(object sender, EventArgs e)
        {
            if (telaServico.ShowDialog() == DialogResult.OK)
            {
                adicionarSevicos = telaServico.servicosSelecionados;
                txtTotal.Text = Convert.ToString(telaServico.valorFinal);
            }
        }
    }
}
