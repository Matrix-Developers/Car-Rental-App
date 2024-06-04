using LocadoraDeVeiculos.Aplicacao.Shared;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.Logs;
using Serilog;
using System;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Aplicacao.GrupoDeVeiculosModule
{
    public class GrupoDeVeiculosAppService : AppServiceBase<GrupoDeVeiculo>
    {
        private readonly IRepository<GrupoDeVeiculo> grupoDeVeiculoRepository;
        private long tempo;
        public GrupoDeVeiculosAppService(IRepository<GrupoDeVeiculo> grupoDeVeiculoRepository)
        {
            this.grupoDeVeiculoRepository = grupoDeVeiculoRepository;
        }

        public override bool InserirEntidade(GrupoDeVeiculo grupoDeVeiculos)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = grupoDeVeiculoRepository.InserirNovo(grupoDeVeiculos);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Grupo de Veiculos {GrupoDeVeiculos} adicionado com sucesso", DateTime.Now, grupoDeVeiculos);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Registro: {Id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Inserir", grupoDeVeiculos, tempo);
            return resultado;
        }
        public override bool EditarEntidade(int id, GrupoDeVeiculo grupoDeVeiculos)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = grupoDeVeiculoRepository.Editar(id, grupoDeVeiculos);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Grupo de Veiculos {GrupoDeVeiculos} editado com sucesso", DateTime.Now, grupoDeVeiculos);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Registro: {Id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Editar", grupoDeVeiculos, tempo);

            return resultado;
        }
        public override bool ExcluirEntidade(int id)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = grupoDeVeiculoRepository.Excluir(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Grupo de Veiculos {Id} excluido com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {Id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Excluir", id, tempo);
            return resultado;

        }
        public override bool ExisteEntidade(int id)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = grupoDeVeiculoRepository.Existe(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Grupo de Veiculos {Id} encontrado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {Id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Existe Entidade", id, tempo);
            return resultado;
        }
        public override GrupoDeVeiculo SelecionarEntidadePorId(int id)
        {
            tempo = DateTime.Now.Millisecond;
            GrupoDeVeiculo grupoDeVeiculo = grupoDeVeiculoRepository.SelecionarPorId(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (grupoDeVeiculo != null)
                Log.Information("{DataEHora} / Grupo de Veiculos {Id} selecionado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {Id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Selecionar Por Id", id, tempo);
            return grupoDeVeiculo;
        }
        public override List<GrupoDeVeiculo> SelecionarTodasEntidade()
        {
            tempo = DateTime.Now.Millisecond;
            List<GrupoDeVeiculo> listGrupoDeVeiculos = grupoDeVeiculoRepository.SelecionarTodos();
            tempo = DateTime.Now.Millisecond - tempo;
            if (listGrupoDeVeiculos != null)
                Log.Information("{DataEHora} / {QtdSelecionados} Grupo de Veiculos selecionados com sucesso", DateTime.Now, listGrupoDeVeiculos.Count);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Selecionar Todos", tempo);
            return listGrupoDeVeiculos;
        }

        #region Métodos privados
        private string VerificarSeNaoPossuiRepetidos(GrupoDeVeiculo grupoVeiculo)
        {

            List<GrupoDeVeiculo> grupoDeVeiculosRegistrados = SelecionarTodasEntidade();
            foreach (GrupoDeVeiculo grupo in grupoDeVeiculosRegistrados)
            {
                if (grupoVeiculo.Nome == grupo.Nome)
                    return "The vehicle group name must be unique.\n";
            }

            return "VALID";
        }

        private string Vaidacoes(GrupoDeVeiculo grupo)
        {
            string resultadoValidacao = grupo.Validar();
            if (resultadoValidacao == "VALID")
                resultadoValidacao = VerificarSeNaoPossuiRepetidos(grupo);

            return resultadoValidacao;
        }
        #endregion
    }
}
