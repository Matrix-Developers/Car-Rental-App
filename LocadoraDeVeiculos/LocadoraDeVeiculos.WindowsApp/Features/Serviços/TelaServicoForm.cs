using LocadoraDeVeiculos.Controladores.ServicoModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
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

namespace LocadoraDeVeiculos.WindowsApp.Features.Servicos
{
    public partial class TelaServicoForm : Form
    {
        private Servico servico;

        public TelaServicoForm()
        {
            InitializeComponent();
        }

        public Servico Servico
        {
            get { return servico; }
            set
            {
                servico = value;

                txtId.Text = servico.Id.ToString();
                txtNome.Text = servico.Nome.ToString();
                txtValor.Text = servico.Valor.ToString();
                if (servico.Tipo == "Calculo Diario")
                    rdbCalcDiaria.Checked = true;
                else
                    rdbTaxaFixa.Checked = true;
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;
            if (!double.TryParse(txtValor.Text, out double valor))
                valor = 0;
            string tipo = "";
            if (rdbCalcDiaria.Checked)
                tipo = "Calculo Diario";
            else
                tipo = "Calculo Fixo";

            servico = new Servico(id, nome, tipo, valor);

            string resultadoValidacao = servico.Validar();

            if (resultadoValidacao != "VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (txtValor.Text.IndexOf(".") >= 0 || txtValor.Text.Length == 0)
                {
                    e.Handled = true;
                }
            }
            else if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void ServicoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }
    }
}
