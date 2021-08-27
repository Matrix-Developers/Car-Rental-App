using LocadoraDeVeiculos.Controladores.ClientesModule;
using LocadoraDeVeiculos.Controladores.ServicoModule;
using LocadoraDeVeiculos.Controladores.VeiculoModule;
using LocadoraDeVeiculos.Dominio.ClienteModule;
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
        public DashControl()
        {
            InitializeComponent();
            controladorVeiculo = new ControladorVeiculo();
            controladorCliente = new ControladorCliente();
            controladorServicos = new ControladorServico();
            MudaLabels();
        }

        private void MudaLabels()
        {
            CarregaDashBoardVeiculo();
            CarregaDashBoardCliente();
            CarregarDashBoardServicos();
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
