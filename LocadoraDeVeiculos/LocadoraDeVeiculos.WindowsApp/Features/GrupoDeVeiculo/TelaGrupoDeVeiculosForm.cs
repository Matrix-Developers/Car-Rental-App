using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnConfirmar_Click(object sender, EventArgs e)
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

            grupoDeVeiculos = new GrupoDeVeiculo(Id, Nome, TaxaPlanoDiario, TaxaPorKmDiario, TaxaPlanoControlado, LimiteKmControlado,TaxaKmExcedidoControlado,TaxaPlanoLivre);

            string resultadoValidacao = grupoDeVeiculos.Validar();

            if (resultadoValidacao != "VALIDO")
            {
                string erro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        //Esses eventos tem muito código duplicado. Podemos abstrair através de extração de método
        private void txtTaxaPlanoDiario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (txtTaxaPlanoDiario.Text.IndexOf(".") >= 0 || txtTaxaPlanoDiario.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtTaxaKmDiario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (txtTaxaPorKmDiario.Text.IndexOf(".") >= 0 || txtTaxaPorKmDiario.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtTaxaPlanoControlado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (txtTaxaPlanoControlado.Text.IndexOf(".") >= 0 || txtTaxaPlanoControlado.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtLimiteKmControlado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtTaxaKmExcedidoControlado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (txtTaxaKmExcedidoControlado.Text.IndexOf(".") >= 0 || txtTaxaKmExcedidoControlado.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtTaxaPlanoLivre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (txtTaxaPlanoLivre.Text.IndexOf(".") >= 0 || txtTaxaPlanoLivre.Text.Length == 0)
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
