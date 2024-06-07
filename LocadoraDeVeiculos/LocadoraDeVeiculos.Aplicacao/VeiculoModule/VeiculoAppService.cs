using LocadoraDeVeiculos.Aplicacao.Shared;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using Serilog;
using System;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Aplicacao.VeiculoModule
{
    public class VeiculoAppService : AppServiceBase<Veiculo>
    {
        private readonly IRepository<Veiculo> veiculoRepository;
        long tempo;

        public VeiculoAppService(IRepository<Veiculo> veiculoRepository)
        {
            this.veiculoRepository = veiculoRepository;
        }

        public override bool InserirEntidade(Veiculo veiculo)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = veiculoRepository.InserirNovo(veiculo);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Veiculo {Veiculo} inserido com sucesso", DateTime.Now, veiculo);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Layer: AppService / Module: Inserir / ID Registro: {Id} {Tempo}ms", DateTime.Now, this.ToString(), veiculo.Id,tempo);

            return resultado;
        }
        public override bool EditarEntidade(int id, Veiculo veiculo)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = veiculoRepository.Editar(id, veiculo);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Veiculo {Veiculo} editado com sucesso", DateTime.Now, veiculo);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Layer: {Layer} / Module: {Modulo} / Registro: {Id} {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Inserir", veiculo,tempo);

            return resultado;
        }
        public override bool ExcluirEntidade(int id)
        {
            tempo = DateTime.Now.Millisecond;
            var veiculo = SelecionarEntidadePorId(id);
            bool resultado;
            if (veiculo.estaAlugado)
            {
                resultado = false;
                Log.Error("{DataEHora} / Feature: {Feature} / Layer: {Layer} / Module: {Modulo} / ID Registro: {Id} / Veículo já está alugado ou é nulo {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Excluir", id, tempo);
            }
            else
            {
                resultado = veiculoRepository.Excluir(id);
                tempo = DateTime.Now.Millisecond - tempo;
                if (resultado)
                    Log.Information("{DataEHora} / Veiculo {Id} excluido com sucesso", DateTime.Now, id);
                else
                    Log.Error("{DataEHora} / Feature: {Feature} / Layer: {Layer} / Module: {Modulo} / ID Registro: {Id} {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Excluir", id, tempo);
            }
            return resultado;
        }
        public override bool ExisteEntidade(int id)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = veiculoRepository.Existe(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Veiculo {Veiculo} encontrado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Layer: {Layer} / Module: {Modulo} / ID Registro: {Id} {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Existe Entidade", id,tempo);
            return resultado;
        }
        public override Veiculo SelecionarEntidadePorId(int id)
        {
            tempo = DateTime.Now.Millisecond;
            Veiculo veiculo = veiculoRepository.SelecionarPorId(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (veiculo != null)
                Log.Information("{DataEHora} / Veiculo {Id} selecionado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Layer: {Layer} / Module: {Modulo} / ID Registro: {Id} {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Selecionar Por Id", id,tempo);
            return veiculo;
        }
        public override List<Veiculo> SelecionarTodasEntidade()
        {
            tempo = DateTime.Now.Millisecond;
            List<Veiculo> listVeiculos = veiculoRepository.SelecionarTodos();
            tempo = DateTime.Now.Millisecond - tempo;
            if (listVeiculos != null)
            {
                Log.Information("{DataEHora} / {QtdSelecionados} Veiculos selecionados com sucesso", DateTime.Now, listVeiculos.Count);
            }
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Layer: {Layer} / Module: {Modulo} {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Selecionar Todos",tempo);
           
            return listVeiculos;
        }
    }
}
