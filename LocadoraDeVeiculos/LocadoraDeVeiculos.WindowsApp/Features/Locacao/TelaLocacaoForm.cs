using LocadoraDeVeiculos.Aplicacao.ClienteModule;
using LocadoraDeVeiculos.Aplicacao.CupomModule;
using LocadoraDeVeiculos.Aplicacao.FuncionarioModule;
using LocadoraDeVeiculos.Aplicacao.ServicoModule;
using LocadoraDeVeiculos.Aplicacao.VeiculoModule;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using LocadoraDeVeiculos.WindowsApp.Servicos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Locacoes
{
    public partial class TelaLocacaoForm : Form //precisa de refatoração
    {
        private readonly TelaSelecionarServicoForm telaServico;
        private Locacao locacao;
        private readonly FuncionarioAppService funcionarioAppService;
        private readonly VeiculoAppService veiculoAppService;
        private readonly ClienteAppService clienteAppService;
        private readonly CupomAppService cupomAppService;
        public List<Servico> Servicos;
        public string TipoSeguro = "Nenhum";

        public TelaLocacaoForm(string titulo, ServicoAppService servicoAppService, FuncionarioAppService funcionarioAppService, VeiculoAppService veiculoAppService, ClienteAppService clienteAppService, CupomAppService cupomAppService)
        {
            this.funcionarioAppService = funcionarioAppService;
            this.veiculoAppService = veiculoAppService;
            this.clienteAppService = clienteAppService;
            this.cupomAppService = cupomAppService;
            Servicos = new List<Servico>();
            InitializeComponent();
            lblTitulo.Text = titulo;
            CarregarDados();
            CarregaCondutor();
            cBoxPlano.SelectedIndex = 0;
            telaServico = new(servicoAppService);
        }

        public Locacao Locacao
        {
            get { return locacao; }

            set
            {
                locacao = value;

                txtId.Text = locacao.Id.ToString();
                cBoxVeiculo.SelectedItem = locacao.Veiculo;
                cBoxFuncionario.SelectedItem = locacao.FuncionarioLocador;
                cBoxCliente.SelectedItem = locacao.ClienteContratante;
                cBoxCondutor.SelectedItem = locacao.ClienteCondutor;
                cBoxPlano.SelectedItem = locacao.TipoDoPlano;
                dateTPDataSaida.Text = locacao.DataDeSaida.ToLongDateString();
                dateTPDataDevolucao.Text = locacao.DataPrevistaDeChegada.ToLongDateString();
                txtTotal.Text = locacao.PrecoLocacao.ToString();
                Servicos = locacao.Servicos;
                TipoSeguro = locacao.TipoDeSeguro;

            }
        }

        private void CarregarDados()
        {
            cBoxFuncionario.DataSource = funcionarioAppService.SelecionarTodasEntidade();
            List<Veiculo> veiculosDisponiveis = new();
            if (lblTitulo.Text.Contains("Edição"))
                veiculosDisponiveis = veiculoAppService.SelecionarTodasEntidade();
            else
                AdicionaApenasVeiculoDisponivel(veiculosDisponiveis);
            cBoxVeiculo.DataSource = veiculosDisponiveis;
            cBoxCliente.DataSource = clienteAppService.SelecionarTodasEntidade();
        }

        private void AdicionaApenasVeiculoDisponivel(List<Veiculo> veiculosDisponiveis)
        {
            foreach (Veiculo item in veiculoAppService.SelecionarTodasEntidade())
                if (!item.estaAlugado)
                    veiculosDisponiveis.Add(item);
        }

        private void CarregaCondutor()
        {
            List<Cliente> clientesPf = new();
            foreach (Cliente cliente in clienteAppService.SelecionarTodasEntidade())
                if (cliente.EhPessoaFisica)
                    clientesPf.Add(cliente);
            cBoxCondutor.DataSource = clientesPf;
        }

        private void BrnConfirmar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string tipoDoPlano = cBoxPlano.Text.Replace(" ", "");
            Veiculo veiculo = cBoxVeiculo.SelectedItem as Veiculo;
            Funcionario funcionarioLocador = cBoxFuncionario.SelectedItem as Funcionario;
            Cliente clienteContratante = cBoxCliente.SelectedItem as Cliente;
            Cliente condutor = cBoxCondutor.SelectedItem as Cliente;
            DateTime dataDeSaida = dateTPDataSaida.Value;
            DateTime dataPrevistaDeChegada = dateTPDataDevolucao.Value;
            string tipoDeSeguro = "Nenhum";
            if (telaServico.seguro.Length > 0)
                tipoDeSeguro = telaServico.seguro;
            Cupom cupom = null;
            bool existe = cupomAppService.ExisteCodigo(txtCupom.Text);
            if (existe)
            {
                cupom = cupomAppService.SelecionarPorCodigo(txtCupom.Text);
                if (cupom.Validade < DateTime.Now)
                    cupom = null;
            }
            if (cupom != null)
                cupomAppService.AtualizarQuantidadeUtilizada(cupom);
            locacao = new Locacao(id, veiculo, funcionarioLocador, clienteContratante, condutor, cupom, dataDeSaida, dataPrevistaDeChegada, tipoDoPlano, tipoDeSeguro, Servicos);
            Veiculo veiculoAtualizado = locacao.Veiculo;
            veiculoAppService.EditarEntidade(locacao.Veiculo.Id, veiculoAtualizado);
            string resultadoValidacao = locacao.Validar();

            if (resultadoValidacao != "VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();
                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);
                DialogResult = DialogResult.None;
            }
        }

        private void BtnServicos_Click(object sender, EventArgs e)
        {
            telaServico.InicializarCampos(Servicos, TipoSeguro, true);

            if (telaServico.ShowDialog() == DialogResult.OK)
            {
                Servicos = telaServico.servicosSelecionados;
                TipoSeguro = telaServico.seguro;
                double precoGarantia = CalcularLocacao.CalcularGarantia();
                double precoSeguro = CalcularLocacao.CalcularSeguro(telaServico.seguro);
                txtTotal.Text = Convert.ToString(precoGarantia + precoSeguro);
            }
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            string cupom = txtCupom.Text;
            bool existe = cupomAppService.ExisteCodigo(cupom);
            if (existe)
                txtCupom.BackColor = Color.Green;
            else
                txtCupom.BackColor = Color.Red;
        }
    }
}
