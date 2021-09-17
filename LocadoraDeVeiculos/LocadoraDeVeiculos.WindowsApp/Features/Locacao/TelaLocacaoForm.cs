using LocadoraDeVeiculos.Controladores.ClientesModule;
using LocadoraDeVeiculos.Controladores.CupomModule;
using LocadoraDeVeiculos.Controladores.FuncionarioModule;
using LocadoraDeVeiculos.Controladores.VeiculoModule;
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
    public partial class TelaLocacaoForm : Form
    {
        private Locacao locacao;
        private FuncionarioRepository controladorFuncionario = new();
        private VeiculoRepository controladorVeiculo = new();
        private ClienteRepository controladorCliente = new();
        private CupomRepository controladorCupom = new();
        public List<Servico> Servicos;
        public string TipoSeguro = "Nenhum";
        ServicosForm telaServico = new();
        public TelaLocacaoForm(string titulo)
        {
            Servicos = new List<Servico>();
            InitializeComponent();
            lblTitulo.Text = titulo;
            CarregarDados();
            CarregaCondutor();
            cBoxPlano.SelectedIndex = 0;
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
            cBoxFuncionario.DataSource = controladorFuncionario.SelecionarTodos();
            List<Veiculo> veiculosDisponiveis = new();
            if (lblTitulo.Text.Contains("Edição"))
                veiculosDisponiveis = controladorVeiculo.SelecionarTodos();
            else
                AdicionaApenasVeiculoDisponivel(veiculosDisponiveis);
            cBoxVeiculo.DataSource = veiculosDisponiveis;
            cBoxCliente.DataSource = controladorCliente.SelecionarTodos();
        }

        private void AdicionaApenasVeiculoDisponivel(List<Veiculo> veiculosDisponiveis)
        {
            foreach (Veiculo item in controladorVeiculo.SelecionarTodos())
                if (!item.estaAlugado)
                    veiculosDisponiveis.Add(item);
        }

        private void CarregaCondutor()
        {
            List<Cliente> clientesPf = new();
            foreach (Cliente cliente in controladorCliente.SelecionarTodos())
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
            bool existe = CupomRepository.ExisteCodigo(txtCupom.Text);
            if (existe)
            {
                cupom = controladorCupom.SelecionarPorCodigo(txtCupom.Text);
                if (cupom.Validade < DateTime.Now)
                    cupom = null;
            }
            if (cupom != null)
            {
                int qtdUtilizada = cupom.QtdUtilizada;
                controladorCupom.AtualizarQtdUtilizada(cupom.Id, ++qtdUtilizada);
            }
            locacao = new Locacao(id, veiculo, funcionarioLocador, clienteContratante, condutor, cupom, dataDeSaida, dataPrevistaDeChegada, tipoDoPlano, tipoDeSeguro, Servicos);
            Veiculo veiculoAtualizado = locacao.Veiculo;
            controladorVeiculo.Editar(locacao.Veiculo.Id, veiculoAtualizado);
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
            telaServico = new ServicosForm();
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
            bool existe = CupomRepository.ExisteCodigo(cupom);
            if (existe)
                txtCupom.BackColor = Color.Green;
            else
                txtCupom.BackColor = Color.Red;
        }
    }
}
