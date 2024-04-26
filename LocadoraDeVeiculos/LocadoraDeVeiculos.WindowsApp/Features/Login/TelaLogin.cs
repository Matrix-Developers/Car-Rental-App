using LocadoraDeVeiculos.Aplicacao.ClienteModule;
using LocadoraDeVeiculos.Aplicacao.CupomModule;
using LocadoraDeVeiculos.Aplicacao.FuncionarioModule;
using LocadoraDeVeiculos.Aplicacao.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Aplicacao.LocacaoModule;
using LocadoraDeVeiculos.Aplicacao.ParceiroModule;
using LocadoraDeVeiculos.Aplicacao.ServicoModule;
using LocadoraDeVeiculos.Aplicacao.VeiculoModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Infra.EntityFramework;
using LocadoraDeVeiculos.Infra.EntityFramework.Features;
using System;
using System.Threading;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Login
{
    public partial class TelaLogin : Form
    {
        private Thread thread;

        private readonly LocadoraDeVeiculosDBContext db;
        private readonly ServicoAppService servicoAppService;
        private readonly ParceiroAppService parceiroAppService;
        private readonly CupomAppService cupomAppService;
        private readonly FuncionarioAppService funcionarioAppService;
        private readonly GrupoDeVeiculosAppService grupoDeVeiculosAppService;
        private readonly ClienteAppService clienteAppService;
        private readonly VeiculoAppService veiculoAppService;
        private readonly LocacaoAppService locacaoAppService;
        private Funcionario funcionarioLogado;

        public TelaLogin()
        {
            InitializeComponent();

            db = new();
            servicoAppService = new(new ServicoORM(db));
            clienteAppService = new(new ClienteORM(db));
            funcionarioAppService = new(new FuncionarioORM(db));
            veiculoAppService = new(new VeiculoORM(db), new ImagemVeiculoORM(db));
            locacaoAppService = new(new LocacaoORM(db));
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

            if (textUsuario.Text == "admin" && textSenha.Text == "admin")
            {
                funcionarioLogado = new Funcionario("admin", "administrador");
                EfetuarLogin();
            }

            else
            {
                foreach (Funcionario funcionario in funcionarioAppService.SelecionarTodasEntidade())
                    if (textUsuario.Text == funcionario.UsuarioAcesso && textSenha.Text == funcionario.Senha)
                    {
                        funcionarioLogado = funcionario;
                        EfetuarLogin();
                        return;
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

            TelaLogin login = new();
            this.Dispose();
            login.Close();
        }

        public void ChamarTelaPrincipal()
        {
            TelaPrincipalForm.FuncionarioLogado = funcionarioLogado;
            Application.Run(new TelaPrincipalForm(servicoAppService, clienteAppService, veiculoAppService, locacaoAppService));
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Por favor contatar o usuário administrador para refazer sua senha");
        }
    }
}