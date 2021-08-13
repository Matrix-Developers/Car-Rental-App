using LocadoraDeVeiculos.Controladores.ServicoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Serviços
{
    public partial class AdicionarServico : Form
    {
        ControladorServico controladorServico;

        public AdicionarServico(ControladorServico controladorServico)
        {
            this.controladorServico = controladorServico;
            InitializeComponent();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            //string nome = txtNome.Text;
            //double valor = Convert.ToDouble(txtNome.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (this.Text.IndexOf(".") >= 0 || this.Text.Length == 0)
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
