using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.TestDataBuilders
{
    public class LocacaoDataBuilder
    {
        private readonly Locacao locacao;
        public LocacaoDataBuilder()
        {
            locacao = new Locacao();
        }

        public LocacaoDataBuilder ComVeiculo(Veiculo veiculo)
        {
            locacao.Veiculo = veiculo;
            return this;
        }
        public LocacaoDataBuilder ComFuncionarioLocador(Funcionario funcionarioLocador)
        {
            locacao.FuncionarioLocador = funcionarioLocador;
            return this;
        }
        public LocacaoDataBuilder ComClienteContratante(Cliente clienteContratante)
        {
            locacao.ClienteContratante = clienteContratante;
            return this;
        }
        public LocacaoDataBuilder ComClienteCondutor(Cliente clienteCondutor)
        {
            locacao.ClienteCondutor = clienteCondutor;
            return this;
        }
        public LocacaoDataBuilder ComCupom(Cupom cupom)
        {
            locacao.Cupom = cupom;
            return this;
        }
        public LocacaoDataBuilder ComDataDeSaida(DateTime dataDeSaida)
        {
            locacao.DataDeSaida = dataDeSaida;
            return this;
        }
        public LocacaoDataBuilder ComDataPrevistaDeChegada(DateTime dataPrevistaDeChegada)
        {
            locacao.DataPrevistaDeChegada = dataPrevistaDeChegada;
            return this;
        }
        public LocacaoDataBuilder ComDataDeChegada()
        {
            locacao.DataDeChegada = DateTime.Today;
            return this;
        }
        public LocacaoDataBuilder ComTipoDoPlano(string tipoDoPlano)
        {
            locacao.TipoDoPlano = tipoDoPlano;
            return this;
        }
        public LocacaoDataBuilder ComTipoDoSeguro(string tipoDoSeguro)
        {
            locacao.TipoDeSeguro = tipoDoSeguro;
            return this;
        }
        public LocacaoDataBuilder ComPrecoLocacao(double precoLocacao)
        {
            locacao.PrecoLocacao = precoLocacao;
            return this;
        }
        public LocacaoDataBuilder ComPrecoDevolucao(double precoDevolucao)
        {
            locacao.PrecoDevolucao = precoDevolucao;
            return this;
        }
        public LocacaoDataBuilder ComEstaAberta(bool estaAberta)
        {
            locacao.EstaAberta = estaAberta;
            return this;
        }
        public LocacaoDataBuilder ComServicos(List<Servico> servicos)
        {
            locacao.Servicos = servicos;
            return this;
        }

        public Locacao Build()
        {
            return locacao;
        }
    }
}
