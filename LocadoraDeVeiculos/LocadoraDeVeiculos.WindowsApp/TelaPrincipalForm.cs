using System;
using System.Windows.Forms;
using LocadoraDeVeiculos.Controladores.ClientesModule;
using LocadoraDeVeiculos.WindowsApp.ClientesModule;
using LocadoraDeVeiculos.WindowsApp.Features.Clientes;
using LocadoraDeVeiculos.WindowsApp.Shared;

namespace LocadoraDeVeiculos.WindowsApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ICadastravel operacoes;
        public static TelaPrincipalForm Instancia;
        public TelaPrincipalForm()
        {
            InitializeComponent();

            Instancia = this;
        }

       

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ConfiguracaoFuncionarioToolBox configuracao = new ConfiguracaoFuncionarioToolBox();

            //ConfigurarToolBox(configuracao);

            //AtualizarRodape(configuracao.TipoCadastro);

            //operacoes = new OperacoesTarefa(new ControladorTarefa());

            //ConfigurarPainelRegistros();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
            ConfiguracaoClienteToolBox configuracao = new ConfiguracaoClienteToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = new OperacoesClientes(new ControladorCliente());

            ConfigurarPainelRegistros();
        }


        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ConfiguracaoTarefaToolBox configuracao = new ConfiguracaoTarefaToolBox();

            //ConfigurarToolBox(configuracao);

            //AtualizarRodape(configuracao.TipoCadastro);

            //operacoes = new OperacoesTarefa(new ControladorTarefa());

            //ConfigurarPainelRegistros();
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ConfiguracaoTarefaToolBox configuracao = new ConfiguracaoTarefaToolBox();

            //ConfigurarToolBox(configuracao);

            //AtualizarRodape(configuracao.TipoCadastro);

            //operacoes = new OperacoesTarefa(new ControladorTarefa());

            //ConfigurarPainelRegistros();
        }

        private void grupoDeVeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ConfiguracaoTarefaToolBox configuracao = new ConfiguracaoTarefaToolBox();

            //ConfigurarToolBox(configuracao);

            //AtualizarRodape(configuracao.TipoCadastro);

            //operacoes = new OperacoesTarefa(new ControladorTarefa());

            //ConfigurarPainelRegistros();
        }
        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

       

        private void ConfigurarPainelRegistros()
        {
            UserControl tabela = operacoes.ObterTabela();

            tabela.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(tabela);
        }

        private void ConfigurarToolBox(IConfiguracaoToolBox configuracao)
        {
            toolboxAcoes.Enabled = true;
            labelTipoCadastro.Text = configuracao.TipoCadastro;

            btnAdicionar.ToolTipText = configuracao.ToolTipAdicionar;
            btnEditar.ToolTipText = configuracao.ToolTipEditar;
            btnExcluir.ToolTipText = configuracao.ToolTipExcluir;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            operacoes.InserirNovoRegistro();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            operacoes.EditarRegistro();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            operacoes.ExcluirRegistro();
        }


    }
}
