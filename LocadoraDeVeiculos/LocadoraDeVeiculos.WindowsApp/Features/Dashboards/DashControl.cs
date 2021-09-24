using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Dashboards
{
    public partial class DashControl : UserControl
    {
        private readonly List<Locacao> todasLocacao;
        private readonly List<Cliente> todosClientes;
        private readonly List<Veiculo> todosVeiculos;
        private readonly List<Servico> todosServicos;

        public DashControl(List<Locacao> todasLocacao, List<Cliente> todosClientes, List<Veiculo> todosVeiculos, List<Servico> todosServicos)
        {
            InitializeComponent();

            this.todasLocacao = todasLocacao;
            this.todosClientes = todosClientes;
            this.todosVeiculos = todosVeiculos;
            this.todosServicos = todosServicos;

            MudaLabels();
        }

        //public DashControl()        //podemos instanciar repositories atraves do appService no construtor
        //{
        //    InitializeComponent();
        //    veiculoAppService = new VeiculoRepository();
        //    clienteAppService = new ClienteRepository();
        //    servicoAppService = new ServicoRepository();
        //    funcionarioAppService = new FuncionarioRepository();
        //    cupomAppService = new();
        //    locacaoAppService = new LocacaoRepository(veiculoAppService, funcionarioAppService, clienteAppService, servicoAppService, cupomAppService);
        //    MudaLabels();
        //}

        private void MudaLabels()
        {
            CarregaDashBoardVeiculo();
            CarregaDashBoardCliente();
            CarregarDashBoardServicos();
            CarregarDashBoardLocacao();
        }

        private void CarregarDashBoardLocacao()
        {
            List<Locacao> locacoesAbertas = new();
            foreach (Locacao locacao in todasLocacao)
                if (locacao.EstaAberta)
                    locacoesAbertas.Add(locacao);

            int retornamHJ = 0;
            int retornam7dias = 0;

            foreach (Locacao locacao in locacoesAbertas)
            {
                if (locacao.DataDeChegada.Date == DateTime.Today)
                    retornamHJ++;
                else if (locacao.DataDeChegada.Date <= DateTime.Today.AddDays(7))
                    retornam7dias++;
            }
            lbRetornoHJ.Text = retornamHJ.ToString();
            lbCarrosAlugados.Text = locacoesAbertas.Count.ToString();
            lbRetornam7.Text = retornam7dias.ToString();

        }

        private void CarregarDashBoardServicos()
        {
            int servicosTotal = todosServicos.Count;

            lbServicos.Text = servicosTotal.ToString();
        }

        private void CarregaDashBoardCliente()
        {
            int clientesTotal = todosClientes.Count;
            int clientesPF = 0;
            int clientesPJ = 0;

            foreach (Cliente cliente in todosClientes)
            {
                if (cliente.EhPessoaFisica)
                    clientesPF++;
                else
                    clientesPJ++;
            }
            lbClientesPJ.Text = clientesPJ.ToString();
            lbClientesPF.Text = clientesPF.ToString();
            lbClientesTotal.Text = clientesTotal.ToString();

        }

        private void CarregaDashBoardVeiculo()
        {
            int carrosNoTotal = todosVeiculos.Count;
            int carrosAlugados = 0;
            int carrosDisponiveis = 0;


            foreach (Veiculo veiculo in todosVeiculos)
            {
                if (veiculo.estaAlugado)
                    carrosAlugados++;
                else
                    carrosDisponiveis++;
            }
            lbCarDisp.Text = carrosDisponiveis.ToString();
            lbCarInd.Text = carrosAlugados.ToString();
            lbCarTotal.Text = carrosNoTotal.ToString();
        }
    }
}
