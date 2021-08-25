using LocadoraDeVeiculos.Controladores.ClientesModule;
using LocadoraDeVeiculos.Controladores.FuncionarioModule;
using LocadoraDeVeiculos.Controladores.VeiculoModule;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.WindowsApp.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Locacoes
{
    public partial class TelaLocacaoForm : Form
    {
        private Locacao locacao;
        private ControladorFuncionario controladorFuncionario = new ControladorFuncionario();
        private ControladorVeiculo controladorVeiculo = new ControladorVeiculo();

        private ControladorCliente controladorCliente = new ControladorCliente();
        public TelaLocacaoForm(string titulo)
        {
            InitializeComponent();
            CarregarDados();
            CarregaCondutor();
            this.Text = titulo;
            lblTitulo.Text = titulo;
            cBoxPlano.SelectedIndex = 0;
        }

        private void CarregarDados()
        {
            cBoxFuncionario.DataSource = controladorFuncionario.SelecionarTodos();
            cBoxVeiculo.DataSource = controladorVeiculo.SelecionarTodos();
            cBoxCliente.DataSource = controladorCliente.SelecionarTodos();
        }

        private void CarregaCondutor()
        {
            List<Cliente> clientesPf = new List<Cliente>();
            foreach (Cliente cliente in controladorCliente.SelecionarTodos())
                if (cliente.EhPessoaFisica)
                    clientesPf.Add(cliente);
            cBoxCondutor.DataSource = clientesPf;
        }

        private void brnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            //List<Servico> servicosSelecionados = 
            ServicosForm telaServico = new ServicosForm();
            telaServico.Show();
        }
    }
}
