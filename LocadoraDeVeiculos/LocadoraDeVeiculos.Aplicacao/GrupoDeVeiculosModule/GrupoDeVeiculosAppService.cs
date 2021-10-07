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
        private readonly IRepository<GrupoDeVeiculo, int> grupoDeVeiculoRepository;
        private readonly IReadOnlyRepository<GrupoDeVeiculo, int> grupoDeVeiculoLeitura;
        private long tempo;
        public GrupoDeVeiculosAppService(IRepository<GrupoDeVeiculo, int> grupoDeVeiculoRepository, IReadOnlyRepository<GrupoDeVeiculo, int> grupoDeVeiculoLeitura)
        {
            this.grupoDeVeiculoRepository = grupoDeVeiculoRepository;
            this.grupoDeVeiculoLeitura = grupoDeVeiculoLeitura;
        }

        public override bool InserirEntidade(GrupoDeVeiculo grupoDeVeiculos)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = grupoDeVeiculoRepository.InserirNovo(grupoDeVeiculos);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Grupo de Veiculos {GrupoDeVeiculos} adicionado com sucesso", DateTime.Now, grupoDeVeiculos);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Registro: {id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Inserir", grupoDeVeiculos, tempo);
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
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Registro: {id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Editar", grupoDeVeiculos, tempo);

            return resultado;
        }
        public override bool ExcluirEntidade(int id)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = grupoDeVeiculoRepository.Excluir(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Grupo de Veiculos {id} excluido com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Excluir", id, tempo);
            return resultado;

        }
        public override bool ExisteEntidade(int id)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = grupoDeVeiculoLeitura.Existe(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Grupo de Veiculos {id} encontrado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Existe Entidade", id, tempo);
            return resultado;
        }
        public override GrupoDeVeiculo SelecionarEntidadePorId(int id)
        {
            tempo = DateTime.Now.Millisecond;
            GrupoDeVeiculo grupoDeVeiculo = grupoDeVeiculoLeitura.SelecionarPorId(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (grupoDeVeiculo != null)
                Log.Information("{DataEHora} / Grupo de Veiculos {id} selecionado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Selecionar Por id", id, tempo);
            return grupoDeVeiculo;
        }
        public override List<GrupoDeVeiculo> SelecionarTodasEntidade()
        {
            tempo = DateTime.Now.Millisecond;
            List<GrupoDeVeiculo> listGrupoDeVeiculos = grupoDeVeiculoLeitura.SelecionarTodos();
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
                    return "O nome do grupo de veículos deve ser único\n";
            }

            return "VALIDO";
        }

        private string Vaidacoes(GrupoDeVeiculo grupo)
        {
            string resultadoValidacao = grupo.Validar();
            if (resultadoValidacao == "VALIDO")
                resultadoValidacao = VerificarSeNaoPossuiRepetidos(grupo);

            return resultadoValidacao;
        }
        #endregion
    }
}
