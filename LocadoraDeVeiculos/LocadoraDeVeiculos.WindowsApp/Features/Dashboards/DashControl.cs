using LocadoraDeVeiculos.Controladores.ClientesModule;
using LocadoraDeVeiculos.Controladores.FuncionarioModule;
using LocadoraDeVeiculos.Controladores.LocacaoModule;
using LocadoraDeVeiculos.Controladores.ServicoModule;
using LocadoraDeVeiculos.Controladores.VeiculoModule;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Dashboards
{
    public partial class DashControl : UserControl
    {
        ControladorVeiculo controladorVeiculo;
        ControladorCliente controladorCliente;
        ControladorServico controladorServicos;
        ControladorLocacao controladorLocacao;
        ControladorFuncionario controladorFuncionario;
        public DashControl()
        {
            InitializeComponent();
            controladorVeiculo = new ControladorVeiculo();
            controladorCliente = new ControladorCliente();
            controladorServicos = new ControladorServico();
            controladorFuncionario = new ControladorFuncionario();
            controladorLocacao = new ControladorLocacao(controladorVeiculo, controladorFuncionario,controladorCliente, controladorServicos);
            MudaLabels();
        }

        private void MudaLabels()
        {
            CarregaDashBoardVeiculo();
            CarregaDashBoardCliente();
            CarregarDashBoardServicos();
            CarregarDashBoardLocacao();
        }

        private void CarregarDashBoardLocacao()
        {
            List<Locacao> todasLocacao = controladorLocacao.SelecionarTodos();
            List<Locacao> locacoesAbertas = new List<Locacao>();
            foreach (Locacao locacao in todasLocacao)
                if (locacao.EstaAberta)
                    locacoesAbertas.Add(locacao);

            int retornamHJ = 0;
            int retornam7dias = 0;
            

            foreach (Locacao locacao in locacoesAbertas)
            {
                if (locacao.DataDeChegada.Date == DateTime.Today )
                {
                    retornamHJ++;
                }
                else if (locacao.DataDeChegada.Date <= DateTime.Today.AddDays(7))
                {
                    retornam7dias++;
                }
            }
            lbRetornoHJ.Text = retornamHJ.ToString();
            lbCarrosAlugados.Text = locacoesAbertas.Count.ToString();
            lbRetornam7.Text = retornam7dias.ToString();
           
        }

        private void CarregarDashBoardServicos()
        {
            List<Servico> todosServicos = controladorServicos.SelecionarTodos();
            int servicosTotal = todosServicos.Count;

            lbServicos.Text = servicosTotal.ToString();
        }

        private void CarregaDashBoardCliente()
        {
            List<Cliente> todosClientes = controladorCliente.SelecionarTodos();
            int clientesTotal = todosClientes.Count;
            int clientesPF = 0;
            int clientesPJ = 0;

            foreach (Cliente cliente in todosClientes)
            {
                if (cliente.EhPessoaFisica)
                {
                    clientesPF++;
                }
                else
                {
                    clientesPJ++;
                }
            }
            lbClientesPJ.Text = clientesPJ.ToString();
            lbClientesPF.Text = clientesPF.ToString();
            lbClientesTotal.Text = clientesTotal.ToString();
          
        }

        private void CarregaDashBoardVeiculo()
        {
            List<Veiculo> TodosVeiculos = controladorVeiculo.SelecionarTodos();
            int carrosNoTotal = TodosVeiculos.Count;
            int carrosAlugados = 0;
            int carrosDisponiveis = 0;


            foreach (Veiculo veiculo in TodosVeiculos)
            {
                if (veiculo.estaAlugado)
                {
                    carrosAlugados++;
                }
                else
                {
                    carrosDisponiveis++;
                }
            }
            lbCarDisp.Text = carrosDisponiveis.ToString();
            lbCarInd.Text = carrosAlugados.ToString();
            lbCarTotal.Text = carrosNoTotal.ToString();
        }


    }
}
