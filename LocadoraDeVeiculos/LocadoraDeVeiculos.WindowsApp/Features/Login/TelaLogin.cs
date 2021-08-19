using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Login
{
    public partial class TelaLogin : Form
    {
        Thread thread;
        public TelaLogin()
        {
            InitializeComponent();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == "admin" && textSenha.Text == "admin")
            {
                MessageBox.Show("Bem vindo " + textUsuario.Text);
                thread = new Thread(ChamarTelaPrincipal);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();

                this.Hide();
                TelaLogin login = new TelaLogin();
                login.Close();
               
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos");
            }
        }
        private void ChamarTelaPrincipal()
        {
            Application.Run(new TelaPrincipalForm()); ;
        }
    }
    
}
