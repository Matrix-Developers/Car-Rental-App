using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.GrupoDeVeiculo
{
    public partial class TarefaGrupoDeVeiculosForm : Form
    {
        private GrupoDeVeiculos grupoDeVeiculos
        public TarefaGrupoDeVeiculosForm()
        {
            InitializeComponent();
        }

        public GrupoDeVeiculos GrupoDeVeiculos
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
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

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
