using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using System;
using System.IO;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Funcionarios
{
    public partial class FuncionarioForm : Form
    {
        private Funcionario funcionario;

        public FuncionarioForm(string titulo)
        {
            InitializeComponent();
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
                textSenha.Text = funcionario.Senha.ToString();
                mskTxtDataAdmissao.Text = funcionario.DataAdmissao.ToString();
                textCargo.Text = funcionario.Cargo.ToString();
                textSalario.Text = funcionario.Salario.ToString();

            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nome = textNome.Text;
            string registroUnico = mskTxtCpf.Text.Replace("-", "").Replace(".", "").Replace(" ", "");
            string endereco = textEndereco.Text;
            string telefone = mskTxtTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            string email = textEmail.Text;
            int matriculaInterna = Convert.ToInt32(textMatriculaInterna.Text);
            string usuarioAcesso = textUsuarioAcesso.Text;
            string senha = textSenha.Text;
            DateTime dataAdmissao;
            if (mskTxtDataAdmissao.Text == null)
                dataAdmissao = DateTime.Now;
            else
                dataAdmissao = Convert.ToDateTime(mskTxtDataAdmissao.Text);
            string cargo = textCargo.Text;
            double salario = Convert.ToDouble(textSalario.Text);

            funcionario = new Funcionario(0, nome, registroUnico, endereco, telefone, email, matriculaInterna, usuarioAcesso, senha, dataAdmissao, cargo, salario, true);

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
