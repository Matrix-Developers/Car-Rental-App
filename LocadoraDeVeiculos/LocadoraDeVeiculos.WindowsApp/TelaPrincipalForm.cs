using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocadoraDeVeiculos.WindowsApp.Clientes;
using LocadoraDeVeiculos.WindowsApp.Funcionarios;
using LocadoraDeVeiculos.WindowsApp.ClientesModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Controladores.FuncionarioModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
using LocadoraDeVeiculos.WindowsApp.Features.Funcionarios;
using LocadoraDeVeiculos.WindowsApp.Features.Servicos;
using LocadoraDeVeiculos.Controladores.ServicoModule;
using LocadoraDeVeiculos.WindowsApp.Features.Clientes;
using LocadoraDeVeiculos.Controladores.ClientesModule;
using LocadoraDeVeiculos.WindowsApp.Features.Veiculos;
using LocadoraDeVeiculos.Controladores.VeiculoModule;
using LocadoraDeVeiculos.WindowsApp.Features.GrupoDeVeiculos;
using LocadoraDeVeiculos.Controladores.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.WindowsApp.Features.Locacoes;
using LocadoraDeVeiculos.Controladores.LocacaoModule;
using LocadoraDeVeiculos.WindowsApp.Features.Devolucoes;

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
      
        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            ConfiguracaoFuncionarioToolBox configuracao = new ConfiguracaoFuncionarioToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = new OperacoesFuncionario(new ControladorFuncionario());

            ConfigurarPainelRegistros();
        }

        private void servicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoServicoToolBox configuracao = new ConfiguracaoServicoToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = new OperacoesServico(new ControladorServico());

            ConfigurarPainelRegistros();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoClienteToolBox configuracao = new ConfiguracaoClienteToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = new OperacoesClientes(new ControladorCliente());

            ConfigurarPainelRegistros();
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoVeiculoToolBox configuracao = new ConfiguracaoVeiculoToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = new OperacoesVeiculo(new ControladorVeiculo());

            ConfigurarPainelRegistros();
        }

        private void grupoDeVeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoGrupoDeVeiculosToolBox configuracao = new ConfiguracaoGrupoDeVeiculosToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = new OperacoesGrupoDeVeiculos(new ControladorGrupoDeVeiculos());

            ConfigurarPainelRegistros();
        }

        public void AtualizarRodape(string mensagem) { labelRodape.Text = mensagem; }

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

        private void ConfigurarPainelRegistros()
        {
            UserControl tabela = operacoes.ObterTabela();

            tabela.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(tabela);
        }

        private void ConfigurarToolBox(IConfiguracaoToolBox configuracao)
        {
            toolBoxAcoes.Enabled = true;
            labelTipoCadastro.Text = configuracao.TipoCadastro;
            btnAdicionar.ToolTipText = configuracao.ToolTipAdicionar;
            btnEditar.ToolTipText = configuracao.ToolTipEditar;
            btnExcluir.ToolTipText = configuracao.ToolTipExcluir;
        }

        private void locarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoLocacaoToolBox configuracao = new ConfiguracaoLocacaoToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = new OperacoesLocacao(new ControladorLocacao(new ControladorVeiculo(), new ControladorFuncionario(), new ControladorCliente()));

            ConfigurarPainelRegistros();
        }

        private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfiguracaoDevolucaoToolBox configuracao = new ConfiguracaoDevolucaoToolBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = new OperacoesDevolucao(new ControladorLocacao(new ControladorVeiculo(), new ControladorFuncionario(), new ControladorCliente()));

            ConfigurarPainelRegistros();
        }
    }
}
