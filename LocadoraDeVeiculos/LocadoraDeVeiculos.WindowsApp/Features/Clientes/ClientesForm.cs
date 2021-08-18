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
using LocadoraDeVeiculos.Dominio.ClienteModule;

namespace LocadoraDeVeiculos.WindowsApp.ClientesModule
{
    public partial class ClientesForm : Form
    {
        private Cliente cliente;
        public ClientesForm()
        {
            InitializeComponent();
        }

        public Cliente Clientes
        {
            get { return cliente; }

            set
            {
                cliente = value;

                textId.Text = cliente.Id.ToString();

                textNome.Text = cliente.Nome;
                maskRegistro.Text = cliente.RegistroUnico;
                textEndereco.Text = cliente.Endereco;
                maskTelefone.Text = cliente.Telefone;
                tetxtEmail.Text = cliente.Email;
                maskedCNH.Text = cliente.Cnh;
                dtpValidade.Text = cliente.ValidadeCnh.ToShortDateString();
                if (cliente.EhPessoaFisica)
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelRegistro.Text = "CPF";
            maskRegistro.Mask =  "000.000.000-00";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelRegistro.Text = "CNPJ";
            maskRegistro.Mask = "00.000.000/0000-00";

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
       

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textId.Text);
            string Nome = textNome.Text;
            string Registro = maskRegistro.Text;
            string Endereco = textEndereco.Text;
            string TeleFone = maskTelefone.Text;
            string Email = tetxtEmail.Text;
            string CNH = maskedCNH.Text;
            DateTime Validade = Convert.ToDateTime(dtpValidade.Text);
            bool ehPessoaFisica = false;
            if (radioButton1.Checked == true)       
                ehPessoaFisica = true;


            Id = 0;
            cliente = new Cliente(Id, Nome, Registro, Endereco, TeleFone, Email, CNH, Validade, ehPessoaFisica);

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
