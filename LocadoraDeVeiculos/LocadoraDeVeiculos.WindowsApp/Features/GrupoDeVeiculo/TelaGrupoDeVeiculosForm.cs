using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
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
                txtTaxaPlanoDiario.Text =grupoDeVeiculos.TaxaPlanoDiario.ToString();
                txtTaxaKMControlado.Text = grupoDeVeiculos.TaxaKmControlado.ToString();
                txtTaxaKMLivre.Text = grupoDeVeiculos.TaxaKmLivre.ToString();
                textQuantKMControl.Text = grupoDeVeiculos.QuantidadeQuilometrosKmControlado.ToString();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            double TaxaPlanoDiario = 0;
            double TaxaKmControlado = 0;
            double TaxaKmLivre = 0;
            int QuantidadeQuilometrosKmControlado = 0;
            int Id = Convert.ToInt32(textId.Text);
            string Nome = textNomeGrupo.Text;
            if(txtTaxaPlanoDiario.Text.Length > 0)
                TaxaPlanoDiario = Convert.ToDouble(txtTaxaPlanoDiario.Text);
            if (txtTaxaKMControlado.Text.Length > 0)
                TaxaKmControlado = Convert.ToDouble(txtTaxaKMControlado.Text);
            if (txtTaxaKMLivre.Text.Length > 0)
                TaxaKmLivre = Convert.ToDouble(txtTaxaKMLivre.Text);
            if (textQuantKMControl.Text.Length > 0)
                QuantidadeQuilometrosKmControlado = Convert.ToInt32(textQuantKMControl.Text);

            grupoDeVeiculos = new GrupoDeVeiculo(Id, Nome, TaxaPlanoDiario, TaxaKmControlado, TaxaKmLivre, QuantidadeQuilometrosKmControlado);

            string resultadoValidacao = grupoDeVeiculos.Validar();

            if (resultadoValidacao != "VALIDO")
            {
                string erro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }


        }

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

        private void txtTaxaKMControlado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (txtTaxaKMControlado.Text.IndexOf(".") >= 0 || txtTaxaKMControlado.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtTaxaKMLivre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (txtTaxaKMLivre.Text.IndexOf(".") >= 0 || txtTaxaKMLivre.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void textQuantKMControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (textQuantKMControl.Text.IndexOf(".") >= 0 || textQuantKMControl.Text.Length == 0)
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
