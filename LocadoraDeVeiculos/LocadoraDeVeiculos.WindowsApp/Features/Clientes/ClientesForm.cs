using LocadoraDeVeiculos.Dominio.ClienteModule;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.ClientesModule
{
    public partial class ClientesForm : Form
    {
        private Cliente cliente;
        public ClientesForm(string titulo)
        {
            InitializeComponent();
            label8.Text = titulo;
            this.Text = titulo;
        }

        public Cliente Clientes
        {
            get { return cliente; }

            set
            {
                cliente = value;

                if (cliente.EhPessoaFisica)
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    dtpValidade.Text = cliente.ValidadeCnh.ToString();
                }
                textId.Text = cliente.Id.ToString();

                textNome.Text = cliente.Nome;
                maskRegistro.Text = cliente.RegistroUnico;
                textEndereco.Text = cliente.Endereco;
                maskTelefone.Text = cliente.Telefone;
                tetxtEmail.Text = cliente.Email;
                maskedCNH.Text = cliente.Cnh;
                if(cliente.ValidadeCnh > DateTime.Today)
                    dtpValidade.Text = cliente.ValidadeCnh.ToString();
            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelRegistro.Text = "CPF";
            maskRegistro.Mask = "000.000.000-00";
            maskedCNH.Enabled = true;
            dtpValidade.Enabled = true;
            maskRegistro.Size = new Size(90, 20);
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelRegistro.Text = "CNPJ";
            maskRegistro.Mask = "00.000.000/0000-00";
            maskedCNH.Enabled = false;
            dtpValidade.Enabled = false;
            maskRegistro.Size = new Size(113, 20);
        }

        private void BtnConfirmar_Click_1(object sender, EventArgs e)
        {
            DateTime? validade = null;
            bool ehPessoaFisica = false;
            string CNH = "";
            int Id = Convert.ToInt32(textId.Text);
            string Nome = textNome.Text;
            string Registro = maskRegistro.Text.Replace("-", "").Replace(".", "").Replace("/", "").Replace(" ", "");
            string Endereco = textEndereco.Text;
            string TeleFone = maskTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            string Email = tetxtEmail.Text;
            if (radioButton1.Checked == true)
            {
                ehPessoaFisica = true;
                validade = Convert.ToDateTime(dtpValidade.Text);
                CNH = maskedCNH.Text.Replace("-", "").Replace(" ", "");
            }

            cliente = new Cliente(Id, Nome, Registro, Endereco, TeleFone, Email, CNH, validade, ehPessoaFisica);

            string resultadoValidacao = cliente.Validar();


            if (resultadoValidacao != "VALIDO")
            {
                string erro = new StringReader(resultadoValidacao).ReadLine();

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }
    }

}
