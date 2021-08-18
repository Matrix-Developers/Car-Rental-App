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
        public TarefaGrupoDeVeiculosForm()
        {
            InitializeComponent();
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
            int Id = Convert.ToInt32(textId.Text);
            string Nome = textNomeGrupo.Text;
            double TaxaPlanoDiario = Convert.ToDouble(txtTaxaPlanoDiario.Text);
            double TaxaKmControlado = Convert.ToDouble(txtTaxaKMControlado.Text);
            double TaxaKmLivre = Convert.ToDouble(txtTaxaKMLivre.Text);
            int QuantidadeQuilometrosKmControlado = Convert.ToInt32(textQuantKMControl.Text);

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
    }
}
