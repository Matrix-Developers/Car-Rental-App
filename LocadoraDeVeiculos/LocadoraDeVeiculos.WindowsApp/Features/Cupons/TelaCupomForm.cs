using LocadoraDeVeiculos.Aplicacao.ParceiroModule;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Cupons
{
    public partial class TelaCupomForm : Form
    {
        private readonly ParceiroAppService parceiroAppService;
        Cupom cupom;

        int qtdUtilizada = 0;
        public TelaCupomForm(string titulo, ParceiroAppService parceiroAppService)
        {
            this.parceiroAppService = parceiroAppService;
            InitializeComponent();
            rBtnValorFixo.Checked = true;
            labelTitulo.Text = titulo;
            CarregarParceiros();
        }

        private void CarregarParceiros()
        {
            cBoxParceiro.DataSource = parceiroAppService.SelecionarTodasEntidade();
        }

        public Cupom Cupom
        {
            get { return cupom; }

            set
            {
                cupom = value;

                txtid.Text = cupom.id.ToString();
                txtNome.Text = cupom.Nome;
                txtCodigo.Text = cupom.Codigo;
                if (cupom.EhDescontoFixo)
                {
                    rBtnValorFixo.Checked = true;
                    rBtnPorcentagem.Checked = false;
                    numUpDownValor.Maximum = 15000;
                }
                else
                {
                    rBtnValorFixo.Checked = false;
                    rBtnPorcentagem.Checked = true;
                    numUpDownValor.Maximum = 100;
                }
                numUpDownValor.Value = Convert.ToDecimal(cupom.Valor);
                numUpDownValorMinimo.Value = Convert.ToDecimal(cupom.ValorMinimo);
                dtpValidade.Value = cupom.Validade;
                cBoxParceiro.SelectedItem = cupom.Parceiro;
                if (cupom.QtdUtilizada > 0)
                    qtdUtilizada = cupom.QtdUtilizada;
            }
        }
        #region Radio Buttons
        private void RBtnValorFixo_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnValorFixo.Checked == true)
            {
                lbValor.Text = "Valor";
                lbValor.Location = new Point(83, 249);
                numUpDownValor.Maximum = 15000;
            }
        }

        private void RBtnPorcentagem_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnPorcentagem.Checked == true)
            {
                lbValor.Text = "Porcentagem";
                lbValor.Location = new Point(44, 249);
                numUpDownValor.Maximum = 100;
            }
        }
        #endregion
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            bool ehDescontoFixo = false;

            int id = 0;
            if (txtid.Text.Length > 0)
                id = Convert.ToInt32(txtid.Text);
            string nome = txtNome.Text;
            string codigo = txtCodigo.Text;
            double valorMinimo = Convert.ToDouble(numUpDownValorMinimo.Value);
            double valor = Convert.ToDouble(numUpDownValor.Value);
            if (rBtnValorFixo.Checked == true)
                ehDescontoFixo = true;
            DateTime validade = dtpValidade.Value;

            Parceiro parceiro = cBoxParceiro.SelectedItem as Parceiro;

            cupom = new Cupom(id, nome, codigo, valor, valorMinimo, ehDescontoFixo, validade, parceiro, qtdUtilizada);

            string resultadoValidacao = cupom.Validar();

            if (resultadoValidacao != "VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
