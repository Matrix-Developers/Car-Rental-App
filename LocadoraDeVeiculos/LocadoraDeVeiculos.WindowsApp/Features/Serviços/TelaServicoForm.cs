using LocadoraDeVeiculos.Dominio.SevicosModule;
using System;
using System.IO;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Servicos
{
    public partial class TelaServicoForm : Form
    {
        private Servico servico;

        public TelaServicoForm(string titulo)
        {
            InitializeComponent();
            this.Text = titulo;
            lblCadastroServico.Text = titulo;
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
                if (servico.EhTaxadoDiario)
                    rdbCalcDiaria.Checked = true;
                else
                    rdbTaxaFixa.Checked = true;
            }
        }

        private void BtnConfirma_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;
            if (!double.TryParse(txtValor.Text, out double valor))
                valor = 0;
            bool ehTaxadoDiario = rdbCalcDiaria.Checked;

            servico = new Servico(id, nome, ehTaxadoDiario, valor);

            string resultadoValidacao = servico.Validar();

            if (resultadoValidacao != "VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                if (txtValor.Text.Contains(".", StringComparison.CurrentCulture) || txtValor.Text.Length == 0)
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
