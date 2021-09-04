using LocadoraDeVeiculos.Controladores.VeiculoModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
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
        ServicosForm telaServico;
        ControladorVeiculo controladorVeiculo =  new ControladorVeiculo();
        public TelaDevolucaoForm(string titulo)
        {
            InitializeComponent();
            lblTitulo.Text = titulo;
            cBoxQtdTanque.SelectedIndex = 0;
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
                dtDevolucao.Value = devolucao.DataPrevistaDeChegada;
                txtValorInicial.Text = devolucao.PrecoLocacao.ToString();
                telaServico.InicializarCampos(Devolucao.Servicos, devolucao.TipoDeSeguro, false);
                AtualizarListBox();
            }
        }

        #region Eventos dos botões
        private void btnSelecionarServicos_Click(object sender, EventArgs e)
        {
            telaServico.InicializarCampos(Devolucao.Servicos, devolucao.TipoDeSeguro, false);
            Devolucao.Servicos.Clear();
            if (telaServico.ShowDialog() == DialogResult.OK)
            {
                Devolucao.Servicos = telaServico.servicosSelecionados;
                AtualizarListBox();
            }
        }
        private void brnConfirmar_Click(object sender, EventArgs e)
        {
            if (dtDevolucao.Value <= devolucao.DataDeSaida)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Data de entrega menor que a de saída");
                DialogResult = DialogResult.None;
            }
            else
            {
                double precoCombustivel = ReceberPrecoCombustivel();
                Devolucao.FecharLocacao(dtDevolucao.Value, precoCombustivel, Convert.ToDouble(txtKmFinal.Text));

                string resultadoValidacao = Devolucao.Validar();
                Veiculo veiculoAtualizado = devolucao.Veiculo;
                controladorVeiculo.Editar(devolucao.Veiculo.Id, veiculoAtualizado);


                if (resultadoValidacao != "VALIDO")
                {
                    string primeiroErro = new StringReader(resultadoValidacao).ReadLine();
                    TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);
                    DialogResult = DialogResult.None;
                }
            }
        }

        private double ReceberPrecoCombustivel()
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
            if (!double.TryParse(txtValorCombustivel.Text, out double valorPorLitro))
                valorPorLitro = 0;
            double precoCombustivel = CalcularLocacao.CalcularDiferencaCombustivel(Devolucao.Veiculo.capacidadeTanque, porcentagemTanque, valorPorLitro);
            return precoCombustivel;
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

            if (Devolucao != null)
                SimularCalculoDevolucao();
        }

        private void rBtn01_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn01.Checked)
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

            SimularCalculoDevolucao();
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

            SimularCalculoDevolucao();
        }

        private void dtDevolucao_ValueChanged(object sender, EventArgs e)
        {
            SimularCalculoDevolucao();
        }
        #endregion

        #region Atualizar lista
        private void AtualizarListBox()
        {
            if (string.IsNullOrEmpty(txtKmFinal.Text))
                txtKmFinal.Text = "0";
            if (string.IsNullOrEmpty(txtValorCombustivel.Text))
                txtValorCombustivel.Text = "0";
            if (Devolucao.Servicos != null)
            {
                cLBoxServicosSelecionados.Items.Clear();
                int i = 0;
                foreach (Servico servico in Devolucao.Servicos)
                {
                    cLBoxServicosSelecionados.Items.Add(servico);
                    cLBoxServicosSelecionados.SetItemChecked(i++, true);
                }
            }
            SimularCalculoDevolucao();
        }
        #endregion

        private void SimularCalculoDevolucao()
        {
            if (!double.TryParse(txtValorInicial.Text, out double precoDevolucao))
                precoDevolucao = 0;
            if (!double.TryParse(txtKmFinal.Text, out double kilometrosRodados))
                precoDevolucao = 0;

            precoDevolucao += ReceberPrecoCombustivel();
            precoDevolucao += CalcularLocacao.CalcularPlano(Devolucao.TipoDoPlano, Devolucao.Veiculo.grupoVeiculos, kilometrosRodados, Devolucao.DataDeSaida, dtDevolucao.Value);
            precoDevolucao += CalcularLocacao.CalcularServicos(Devolucao.Servicos, Devolucao.DataDeSaida, dtDevolucao.Value);
            precoDevolucao +=  CalcularLocacao.CalcularMultaDevolucaoAtrasada(Devolucao.PrecoDevolucao, Devolucao.DataPrevistaDeChegada, Devolucao.DataDeChegada);
            precoDevolucao -= CalcularLocacao.CalcularCupomDesconto(precoDevolucao, Devolucao.Cupom);
            txtValorTotal.Text = Math.Round(precoDevolucao, 2).ToString();
        }
    }
}
