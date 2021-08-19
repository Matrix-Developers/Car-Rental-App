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
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.WindowsApp.Funcionarios;

namespace LocadoraDeVeiculos.WindowsApp.Funcionarios
{
    public partial class FuncionarioForm : Form
    {
        private Funcionario funcionario;

        public FuncionarioForm(string titulo)
        {
            InitializeComponent();
            this.Text = titulo;
            lbTituloCadastroDeFuncionarios.Text = titulo;
        }

        public Funcionario Funcionario
        {
            get { return funcionario; }

            set
            {
                funcionario = value;

                textId.Text = funcionario.Id.ToString();
                textNome.Text = funcionario.Nome.ToString();
                mskTxtCpf.Text = funcionario.RegistroUnico;
                textEndereco.Text = funcionario.Endereco.ToString();
                mskTxtTelefone.Text = funcionario.Telefone.ToString();
                textEmail.Text = funcionario.Email.ToString();
                textMatriculaInterna.Text = funcionario.MatriculaInterna.ToString();
                textUsuarioAcesso.Text = funcionario.UsuarioAcesso.ToString();
                mskTxtDataAdmissao.Text = funcionario.DataAdmissao.ToString();
                textCargo.Text = funcionario.Cargo.ToString();
                textSalario.Text = funcionario.Salario.ToString();
                
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nome = textNome.Text;
            string registroUnico = mskTxtCpf.Text;
            string endereco = textEndereco.Text;

            string telefone = mskTxtTelefone.Text;
            string email = textEmail.Text;
            int matriculaInterna = Convert.ToInt32(textMatriculaInterna.Text);
            string usuarioAcesso = textUsuarioAcesso.Text;
            DateTime dataAdmissao;
            if (mskTxtDataAdmissao.Text == null)
                dataAdmissao = DateTime.Now;
            else
                dataAdmissao = Convert.ToDateTime(mskTxtDataAdmissao.Text);
            string cargo = textCargo.Text;
            double salario = Convert.ToDouble(textSalario.Text);
             
            funcionario = new Funcionario(0,nome,registroUnico,endereco,telefone,email,matriculaInterna,usuarioAcesso,dataAdmissao,cargo,salario,true);

            string resultadoValidacao = funcionario.Validar();

            if (resultadoValidacao != "VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();
                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);
                DialogResult = DialogResult.None;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }
    }
}
