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

        public GrupoDeVeiculosAppService(IRepository<GrupoDeVeiculo> grupoDeVeiculoRepository)
        {
            this.grupoDeVeiculoRepository = grupoDeVeiculoRepository;
        }

        public override bool InserirEntidade(GrupoDeVeiculo grupoDeVeiculos)
        {
            bool resultado = grupoDeVeiculoRepository.InserirNovo(grupoDeVeiculos);
            if (resultado)
                Log.Information("{DataEHora} / Grupo de Veiculos {GrupoDeVeiculos} adicionado com sucesso", DateTime.Now, grupoDeVeiculos);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Inserir", grupoDeVeiculos);
            return resultado;
        }
        public override bool EditarEntidade(int id, GrupoDeVeiculo grupoDeVeiculos)
        {
            bool resultado = grupoDeVeiculoRepository.Editar(id, grupoDeVeiculos);
            if (resultado)
                Log.Information("{DataEHora} / Grupo de Veiculos {GrupoDeVeiculos} editado com sucesso", DateTime.Now, grupoDeVeiculos);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Editar", grupoDeVeiculos);

            return resultado;
        }
        public override bool ExcluirEntidade(int id)
        {
            bool resultado = grupoDeVeiculoRepository.Excluir(id);
            if (resultado)
                Log.Information("{DataEHora} / Grupo de Veiculos {Id} excluido com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Excluir", id);
            return resultado;

        }
        public override bool ExisteEntidade(int id)
        {
            bool resultado = grupoDeVeiculoRepository.Existe(id);
            if (resultado)
                Log.Information("{DataEHora} / Grupo de Veiculos {Id} encontrado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Existe Entidade", id);
            return resultado;
        }
        public override GrupoDeVeiculo SelecionarEntidadePorId(int id)
        {
            GrupoDeVeiculo grupoDeVeiculo = grupoDeVeiculoRepository.SelecionarPorId(id);
            if (grupoDeVeiculo != null)
                Log.Information("{DataEHora} / Grupo de Veiculos {Id} selecionado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Selecionar Por Id", id);
            return grupoDeVeiculo;
        }
        public override List<GrupoDeVeiculo> SelecionarTodasEntidade()
        {
            List<GrupoDeVeiculo> listGrupoDeVeiculos = grupoDeVeiculoRepository.SelecionarTodos();
            if (listGrupoDeVeiculos != null)
                Log.Information("{DataEHora} / {QtdSelecionados} Grupo de Veiculos selecionados com sucesso", DateTime.Now, listGrupoDeVeiculos.Count);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Selecionar Todos");
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
