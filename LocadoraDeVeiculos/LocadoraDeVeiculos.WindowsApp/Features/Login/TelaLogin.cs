using LocadoraDeVeiculos.Controladores.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
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
        private readonly ControladorFuncionario controlador;
        Thread thread;
        public TelaLogin()
        {
            InitializeComponent();
            controlador = new ControladorFuncionario();
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if (textUsuario.Text == "admin" && textSenha.Text == "admin")
                EfetuarLogin();

            else
            {
                foreach (Funcionario funcionario in controlador.SelecionarTodos())
                {
                    if (textUsuario.Text == funcionario.UsuarioAcesso && textSenha.Text == funcionario.Senha)
                    {
                        EfetuarLogin();
                        return;
                    }
                }

                textUsuario.Clear();
                textSenha.Clear();
                MessageBox.Show("Login ou senha inválidos");
            }

        }

        private void EfetuarLogin()
        {
            MessageBox.Show("Bem vindo " + textUsuario.Text);
            thread = new Thread(ChamarTelaPrincipal);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();


            TelaLogin login = new TelaLogin();
            this.Dispose();
            login.Close();
        }

        public void ChamarTelaPrincipal()
        {
            Application.Run(new TelaPrincipalForm()); ;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Por favor contatar o usuário administrador para refazer sua senha");
        }
    }
}