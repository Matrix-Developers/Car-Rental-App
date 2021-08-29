﻿using LocadoraDeVeiculos.Controladores.ClientesModule;
using LocadoraDeVeiculos.Controladores.FuncionarioModule;
using LocadoraDeVeiculos.Controladores.VeiculoModule;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.RelacionamentoLocServModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using LocadoraDeVeiculos.WindowsApp.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public List<Servico> Servicos = new List<Servico>();
        ServicosForm telaServico = new ServicosForm();
        public TelaLocacaoForm(string titulo)
        {
            InitializeComponent();
            CarregarDados();
            CarregaCondutor();
            this.Text = titulo;
            lblTitulo.Text = titulo;
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
            }
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
            int id = 0;
            if (txtId.Text.Length > 0)
                id = Convert.ToInt32(txtId.Text);
            string tipoDoPlano = "PlanoDiario";

            Veiculo veiculo = cBoxVeiculo.SelectedItem as Veiculo;
            Funcionario funcionarioLocador = cBoxFuncionario.SelectedItem as Funcionario;
            Cliente clienteContratante = cBoxCliente.SelectedItem as Cliente;
            Cliente condutor = cBoxCondutor.SelectedItem as Cliente;
            DateTime dataDeSaida = dateTPDataSaida.Value;
            DateTime dataPrevistaDeChegada = dateTPDataDevolucao.Value;
            string tipoDeSeguro = telaServico.seguro;            
            locacao = new Locacao(id, veiculo, funcionarioLocador, clienteContratante, condutor, dataDeSaida, dataPrevistaDeChegada, tipoDoPlano, tipoDeSeguro, Servicos);
            string resultadoValidacao = locacao.Validar();

            if (resultadoValidacao != "VALIDO")
            {
                string primeiroErro = new StringReader(resultadoValidacao).ReadLine();
                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);
                DialogResult = DialogResult.None;
            }
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            if (telaServico.ShowDialog() == DialogResult.OK)
            {
                Servicos = telaServico.servicosSelecionados;
                txtTotal.Text = Convert.ToString(telaServico.valorFinal);
            }
        }
    }
}