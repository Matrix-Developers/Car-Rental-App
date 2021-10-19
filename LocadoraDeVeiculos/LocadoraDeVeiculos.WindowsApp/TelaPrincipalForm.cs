using LocadoraDeVeiculos.Aplicacao.ClienteModule;
using LocadoraDeVeiculos.Aplicacao.LocacaoModule;
using LocadoraDeVeiculos.Aplicacao.ServicoModule;
using LocadoraDeVeiculos.Aplicacao.VeiculoModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.WindowsApp.Features.Clientes;
using LocadoraDeVeiculos.WindowsApp.Features.Cupons;
using LocadoraDeVeiculos.WindowsApp.Features.Dashboards;
using LocadoraDeVeiculos.WindowsApp.Features.Devolucoes;
using LocadoraDeVeiculos.WindowsApp.Features.Funcionarios;
using LocadoraDeVeiculos.WindowsApp.Features.GrupoDeVeiculos;
using LocadoraDeVeiculos.WindowsApp.Features.Locacoes;
using LocadoraDeVeiculos.WindowsApp.Features.Parceiros;
using LocadoraDeVeiculos.WindowsApp.Features.Servicos;
using LocadoraDeVeiculos.WindowsApp.Features.Veiculos;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System;
using System.Windows.Forms;
using Autofac;

namespace LocadoraDeVeiculos.WindowsApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ICadastravel operacoes;
        private static TelaPrincipalForm instancia;
        private static Funcionario funcionarioLogado;

        private readonly ServicoAppService servicoAppService;
        private readonly VeiculoAppService veiculoAppService;
        private readonly LocacaoAppService locacaoAppService;
        private readonly ClienteAppService clienteAppService;        
        
        
        public static TelaPrincipalForm Instancia { get => instancia; set => instancia = value; }
        public static Funcionario FuncionarioLogado { get => funcionarioLogado; set => funcionarioLogado = value; }

        public TelaPrincipalForm(ServicoAppService servicoAppService, ClienteAppService clienteAppService, VeiculoAppService veiculoAppService, LocacaoAppService locacaoAppService)
        {
            InitializeComponent();
        
            instancia = this;
            this.servicoAppService = servicoAppService;
            this.clienteAppService = clienteAppService;
            this.veiculoAppService = veiculoAppService;
            this.locacaoAppService = locacaoAppService;
        
            MostrarDashBoard();
        }

        public TelaPrincipalForm()
        {
            InitializeComponent();
            instancia = this;
            MostrarDashBoard();
        }

        #region Opções do menu strip
        private void InícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarDashBoard();
        }
        private void FuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoFuncionarioToolBox configuracao = new();

            ConfigurarToolBox(configuracao, false);
            btnAdicionar.Image = Properties.Resources._36x1;

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = AutoFac.Container.Resolve<OperacoesFuncionario>();

            ConfigurarPainelRegistros();
        }

        private void ServicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoServicoToolBox configuracao = new();

            ConfigurarToolBox(configuracao, false);
            btnAdicionar.Image = Properties.Resources._36x1;

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = AutoFac.Container.Resolve<OperacoesServico>();

            ConfigurarPainelRegistros();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoClienteToolBox configuracao = new();

            ConfigurarToolBox(configuracao, false);
            btnAdicionar.Image = Properties.Resources._36x1;

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = AutoFac.Container.Resolve<OperacoesClientes>();

            ConfigurarPainelRegistros();
        }

        private void VeiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoVeiculoToolBox configuracao = new();

            ConfigurarToolBox(configuracao, false);
            btnAdicionar.Image = Properties.Resources._36x1;

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = AutoFac.Container.Resolve<OperacoesVeiculo>();

            ConfigurarPainelRegistros();
        }

        private void GrupoDeVeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoGrupoDeVeiculosToolBox configuracao = new();

            ConfigurarToolBox(configuracao, false);
            btnAdicionar.Image = Properties.Resources._36x1;

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = AutoFac.Container.Resolve<OperacoesGrupoDeVeiculos>();

            ConfigurarPainelRegistros();
        }

        private void LocarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoLocacaoToolBox configuracao = new();

            ConfigurarToolBox(configuracao, false);
            btnAdicionar.Image = Properties.Resources._36x1;

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = AutoFac.Container.Resolve<OperacoesLocacao>();

            ConfigurarPainelRegistros();
        }        

        private void DevoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoDevolucaoToolBox configuracao = new();

            ConfigurarToolBox(configuracao, true);
            btnAdicionar.Image = Properties.Resources.car_32px;

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = AutoFac.Container.Resolve<OperacoesDevolucao>();

            ConfigurarPainelRegistros();
        }

        private void CuponsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoCupomToolBox configuracao = new();

            ConfigurarToolBox(configuracao, false);
            btnAdicionar.Image = Properties.Resources._36x1;

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = AutoFac.Container.Resolve<OperacoesCupom>();

            ConfigurarPainelRegistros();
        }

        private void ParceirosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoParceiroToolBox configuracao = new();

            ConfigurarToolBox(configuracao, false);
            btnAdicionar.Image = Properties.Resources._36x1;

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = AutoFac.Container.Resolve<OperacoesParceiro>();

            ConfigurarPainelRegistros();
        }
        #endregion

        #region Ações dos botões
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            operacoes.InserirNovoRegistro();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            operacoes.EditarRegistro();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            operacoes.ExcluirRegistro();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            operacoes.FiltrarRegistros();
        }
        #endregion

        #region Métodos privados
        private void ConfigurarPainelRegistros()
        {
            UserControl tabela = operacoes.ObterTabela();
            tabela.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(tabela);
        }

        private void ConfigurarPainelDashBoard()
        {
            DashControl tabela = new(locacaoAppService.SelecionarTodasEntidade(), clienteAppService.SelecionarTodasEntidade(), veiculoAppService.SelecionarTodasEntidade(), servicoAppService.SelecionarTodasEntidade());
            tabela.Dock = DockStyle.Fill;
            panelRegistros.Controls.Clear();
            panelRegistros.Controls.Add(tabela);
        }

        private void ConfigurarToolBox(IConfiguracaoToolBox configuracao, bool possivelFiltrar)
        {
            toolBoxAcoes.Enabled = true;
            if (possivelFiltrar)
                btnFiltrar.Enabled = true;
            else
                btnFiltrar.Enabled = false;
            labelTipoCadastro.Text = configuracao.TipoCadastro;
            btnAdicionar.ToolTipText = configuracao.ToolTipAdicionar;
            btnEditar.ToolTipText = configuracao.ToolTipEditar;
            btnExcluir.ToolTipText = configuracao.ToolTipExcluir;
        }

        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        private void MostrarDashBoard()
        {
            ConfiguracaoDashboardToolBox configuracao = new();
            ConfigurarToolBox(configuracao, false);
            toolBoxAcoes.Enabled = false;
            AtualizarRodape(configuracao.TipoCadastro);
            ConfigurarPainelDashBoard();
        }
        #endregion
    }
}
