using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.WindowsApp.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        ServicosForm telaServico;
        public TelaDevolucaoForm(string titulo)
        {
            InitializeComponent();
            lblTitulo.Text = titulo;
            cBoxQtdTanque.SelectedIndex = 0;
            AtualizarListBox();
            telaServico = new ServicosForm();
        }

        public Locacao Devolucao
        {
            get { return devolucao; }

            set
            {
                devolucao = value;

                txtId.Text = devolucao.Id.ToString();
                txtKmInicial.Text = devolucao.Veiculo.kilometragem.ToString();
                txtVeiculo.Text = devolucao.Veiculo.modelo;
                txtFuncionario.Text = devolucao.FuncionarioLocador.Nome;
                txtCliente.Text = devolucao.ClienteContratante.Nome;
                txtCondutor.Text = devolucao.ClienteCondutor.Nome;
                txtPlano.Text = devolucao.TipoDoPlano;
                txtDataLocacao.Text = devolucao.DataDeSaida.ToString();
                txtDataDevolucao.Text = devolucao.DataPrevistaDeChegada.ToString();
                txtValorInicial.Text = devolucao.PrecoLocacao.ToString();
                adicionarSevicos = Devolucao.Servicos;
                AtualizarListBox();
                telaServico.InicializarCampos(devolucao.Servicos, devolucao.TipoDeSeguro);
            }
        }

        #region Eventos dos botões
        private void btnSelecionarServicos_Click(object sender, EventArgs e)
        {
            if (telaServico.ShowDialog() == DialogResult.OK)
            {
                adicionarSevicos = telaServico.servicosSelecionados;
                //txtTotal.Text = Convert.ToString(telaServico.valorFinal);
                AtualizarListBox();
            }
        }
        private void brnConfirmar_Click(object sender, EventArgs e)
        {
            double porcentagemTanque = 0;
            switch (cBoxQtdTanque.SelectedItem.ToString())
            {
                case "1/4":
                    porcentagemTanque = 0.25;
                    break;
                case "1/2":
                    porcentagemTanque = 0.5;
                    break;
                case "3/4":
                    porcentagemTanque = 0.75;
                    break;
                case "1/1":
                    porcentagemTanque = 1;
                    break;
            }
            double valorPorLitro = Convert.ToDouble(txtValorCombustivel.Text);
            double precoCombustivel = CalcularLocacao.CalcularDiferencaCombustivel(Devolucao.Veiculo.capacidadeTanque, porcentagemTanque, valorPorLitro);
            Devolucao.FecharLocacao(dtDevolucao.Value, precoCombustivel, Convert.ToDouble(txtKmFinal.Text));

            string resultadoValidacao = Devolucao.Validar();

            MessageBox.Show("Devolucao " + Devolucao.PrecoDevolucao);

            if (resultadoValidacao != "VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();
                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);
                DialogResult = DialogResult.None;
            }

        }
        #endregion

        #region rButton e cBox do combustivel
        private void cBoxQtdTanque_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxQtdTanque.SelectedIndex == 0)
                rBtn01.Checked = true;
            else if (cBoxQtdTanque.SelectedIndex == 1)
                rBtn14.Checked = true;
            else if (cBoxQtdTanque.SelectedIndex == 2)
                rBtn12.Checked = true;
            else if (cBoxQtdTanque.SelectedIndex == 3)
                rBtn34.Checked = true;
            else if (cBoxQtdTanque.SelectedIndex == 4)
                rBtn11.Checked = true;
        }
        
        private void rBtn01_CheckedChanged(object sender, EventArgs e)
        {
            if(rBtn01.Checked)
                cBoxQtdTanque.SelectedIndex = 0;
        }

        private void rBtn14_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn14.Checked)
                cBoxQtdTanque.SelectedIndex = 1;
        }

        private void rBtn12_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn12.Checked)
                cBoxQtdTanque.SelectedIndex = 2;
        }

        private void rBtn34_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn34.Checked)
                cBoxQtdTanque.SelectedIndex = 3;
        }

        private void rBtn11_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn11.Checked)
                cBoxQtdTanque.SelectedIndex = 4;
        }
        #endregion

        #region Validação para aceitar apenas números
        private void txtValorCombustivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (txtValorCombustivel.Text.IndexOf(".") >= 0 || txtValorCombustivel.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txtKmFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (txtKmFinal.Text.IndexOf(".") >= 0 || txtKmFinal.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Atualizar lista
        private void AtualizarListBox()
        {
            if (this.adicionarSevicos != null)
            {
                cLBoxServicosSelecionados.Items.Clear();
                foreach (Servico servico in this.adicionarSevicos)
                    cLBoxServicosSelecionados.Items.Add(servico);
            }
        }
        #endregion
    }
}
