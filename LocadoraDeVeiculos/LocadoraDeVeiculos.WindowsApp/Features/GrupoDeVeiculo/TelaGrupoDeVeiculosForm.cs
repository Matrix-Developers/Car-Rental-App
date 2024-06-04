using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.GrupoDeVeiculos
{
    public partial class TarefaGrupoDeVeiculosForm : Form
    {
        private GrupoDeVeiculo grupoDeVeiculos;
        public TarefaGrupoDeVeiculosForm(string titulo)
        {
            InitializeComponent();
            this.Text = titulo;
            lblCadastroGrupoDeVeiculos.Text = titulo;
        }

        public GrupoDeVeiculo GrupoDeVeiculos
        {
            get { return grupoDeVeiculos; }

            set
            {
                grupoDeVeiculos = value;

                textId.Text = grupoDeVeiculos.Id.ToString();
                textNomeGrupo.Text = grupoDeVeiculos.Nome;
                txtTaxaPlanoDiario.Text = grupoDeVeiculos.TaxaPlanoDiario.ToString();
                txtTaxaPorKmDiario.Text = grupoDeVeiculos.TaxaPorKmDiario.ToString();
                txtTaxaPlanoControlado.Text = grupoDeVeiculos.TaxaPlanoControlado.ToString();
                txtLimiteKmControlado.Text = grupoDeVeiculos.LimiteKmControlado.ToString();
                txtTaxaKmExcedidoControlado.Text = grupoDeVeiculos.TaxaKmExcedidoControlado.ToString();
                txtTaxaPlanoLivre.Text = grupoDeVeiculos.TaxaPlanoLivre.ToString();

            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textId.Text);
            string Nome = textNomeGrupo.Text;
            double TaxaPlanoDiario = 0;
            double TaxaPorKmDiario = 0;
            double TaxaPlanoControlado = 0;
            int LimiteKmControlado = 0;
            double TaxaKmExcedidoControlado = 0;
            double TaxaPlanoLivre = 0;
            if (txtTaxaPlanoDiario.Text.Length > 0)
                TaxaPlanoDiario = Convert.ToDouble(txtTaxaPlanoDiario.Text, CultureInfo.InvariantCulture);
            if (txtTaxaPorKmDiario.Text.Length > 0)
                TaxaPorKmDiario = Convert.ToDouble(txtTaxaPorKmDiario.Text, CultureInfo.InvariantCulture);
            if (txtTaxaPlanoControlado.Text.Length > 0)
                TaxaPlanoControlado = Convert.ToDouble(txtTaxaPlanoControlado.Text, CultureInfo.InvariantCulture);
            if (txtLimiteKmControlado.Text.Length > 0)
                LimiteKmControlado = Convert.ToInt32(txtLimiteKmControlado.Text);
            if (txtTaxaKmExcedidoControlado.Text.Length > 0)
                TaxaKmExcedidoControlado = Convert.ToDouble(txtTaxaKmExcedidoControlado.Text, CultureInfo.InvariantCulture);
            if (txtTaxaPlanoLivre.Text.Length > 0)
                TaxaPlanoLivre = Convert.ToDouble(txtTaxaPlanoLivre.Text, CultureInfo.InvariantCulture);

            grupoDeVeiculos = new GrupoDeVeiculo(Id, Nome, TaxaPlanoDiario, TaxaPorKmDiario, TaxaPlanoControlado, LimiteKmControlado, TaxaKmExcedidoControlado, TaxaPlanoLivre);

            string resultadoValidacao = grupoDeVeiculos.Validar();

            if (resultadoValidacao != "VALID")
            {
                string erro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        //Esses eventos tem muito código duplicado. Podemos abstrair através de extração de método
        private void TxtTaxaPlanoDiario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (txtTaxaPlanoDiario.Text.Contains(".", StringComparison.CurrentCulture) || txtTaxaPlanoDiario.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TxtTaxaKmDiario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (txtTaxaPorKmDiario.Text.Contains(".", StringComparison.CurrentCulture) || txtTaxaPorKmDiario.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TxtTaxaPlanoControlado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (txtTaxaPlanoControlado.Text.Contains(".", StringComparison.CurrentCulture) || txtTaxaPlanoControlado.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TxtLimiteKmControlado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TxtTaxaKmExcedidoControlado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (txtTaxaKmExcedidoControlado.Text.Contains(".", StringComparison.CurrentCulture) || txtTaxaKmExcedidoControlado.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void TxtTaxaPlanoLivre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (txtTaxaPlanoLivre.Text.Contains(".", StringComparison.CurrentCulture) || txtTaxaPlanoLivre.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
