using LocadoraDeVeiculos.Aplicacao.ClienteModule;
using LocadoraDeVeiculos.Aplicacao.CupomModule;
using LocadoraDeVeiculos.Aplicacao.FuncionarioModule;
using LocadoraDeVeiculos.Aplicacao.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Aplicacao.LocacaoModule;
using LocadoraDeVeiculos.Aplicacao.ParceiroModule;
using LocadoraDeVeiculos.Aplicacao.ServicoModule;
using LocadoraDeVeiculos.Aplicacao.VeiculoModule;
using LocadoraDeVeiculos.Controladores.ClientesModule;
using LocadoraDeVeiculos.Controladores.CupomModule;
using LocadoraDeVeiculos.Controladores.FuncionarioModule;
using LocadoraDeVeiculos.Controladores.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Controladores.ImagemVeiculoModule;
using LocadoraDeVeiculos.Controladores.LocacaoModule;
using LocadoraDeVeiculos.Controladores.ParceiroModule;
using LocadoraDeVeiculos.Controladores.ServicoModule;
using LocadoraDeVeiculos.Controladores.VeiculoModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using System;
using System.Threading;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Login
{
    public partial class TelaLogin : Form
    {
        private Thread thread;

        private readonly ServicoAppService servicoAppService;
        private readonly ParceiroAppService parceiroAppService;
        private readonly CupomAppService cupomAppService;
        private readonly FuncionarioAppService funcionarioAppService;
        private readonly GrupoDeVeiculosAppService grupoDeVeiculosAppService;
        private readonly ClienteAppService clienteAppService;
        private readonly VeiculoAppService veiculoAppService;
        private readonly LocacaoAppService locacaoAppService;

        public TelaLogin()
        {
            InitializeComponent();
            servicoAppService = new(new ServicoRepository());
            parceiroAppService = new(new ParceiroRepository());
            cupomAppService = new(new CupomRepository());
            funcionarioAppService = new(new FuncionarioRepository());
            grupoDeVeiculosAppService = new(new GrupoDeVeiculosRepository());
            clienteAppService = new(new ClienteRepository());
            veiculoAppService = new(new VeiculoRepository(), new ImagemVeiculoRepository());
            locacaoAppService = new(new LocacaoRepository(new VeiculoRepository(), new FuncionarioRepository(), new ClienteRepository(), new ServicoRepository(), new CupomRepository())); //remover repository dentro de repositor
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

            if (textUsuario.Text == "admin" && textSenha.Text == "admin")
                EfetuarLogin();

            else
            {
                foreach (Funcionario funcionario in funcionarioAppService.SelecionarTodos())
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


            TelaLogin login = new();
            this.Dispose();
            login.Close();
        }

        public void ChamarTelaPrincipal()
        {
            Application.Run(new TelaPrincipalForm(servicoAppService, parceiroAppService, cupomAppService, funcionarioAppService, grupoDeVeiculosAppService, clienteAppService, veiculoAppService, locacaoAppService));
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Por favor contatar o usuário administrador para refazer sua senha");
        }
    }
}