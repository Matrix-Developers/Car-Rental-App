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

        public override string InserirEntidade(GrupoDeVeiculo grupoDeVeiculos)
        {
            string resultadoValidacao = Vaidacoes(grupoDeVeiculos);

            if (resultadoValidacao == "VALIDO")
            {
                GeradorLog.ConfigurarLog();
                bool resultado = grupoDeVeiculoRepository.InserirNovo(grupoDeVeiculos);
                if (resultado)
                    Log.Information("{DataEHora} / GrupoDeVeiculos {Id} inserido com sucesso", DateTime.Now, grupoDeVeiculos.Id);
                else
                    Log.Error("{DataEHora} / Feature: {Feature} / Camada: AppService / Módulo: Inserir / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), grupoDeVeiculos.Id);
            }

            return resultadoValidacao;
        }
        public override string EditarEntidade(int id, GrupoDeVeiculo grupoDeVeiculos)
        {
            string resultadoValidacao = Vaidacoes(grupoDeVeiculos);

            
            if (resultadoValidacao == "VALIDO")
            {
                GeradorLog.ConfigurarLog();
                bool resultado = grupoDeVeiculoRepository.Editar(id, grupoDeVeiculos);
                if (resultado)
                    Log.Information("{DataEHora} / GrupoDeVeiculos {Id} editado com sucesso", DateTime.Now, id);
                else
                    Log.Error("{DataEHora} / Feature: {Feature} / Camada: AppService / Módulo: Editar / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), id);
            }

            return resultadoValidacao;
        }
        public override bool ExcluirEntidade(int id)
        {
            GeradorLog.ConfigurarLog();
            bool resultado = grupoDeVeiculoRepository.Excluir(id);
            if (resultado)
                Log.Information("{DataEHora} / GrupoDeVeiculos {Id} excluido com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: AppService / Módulo: Excluir / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), id);
            return resultado;

        }
        public override bool ExisteEntidade(int id)
        {
            GeradorLog.ConfigurarLog();
            bool resultado = grupoDeVeiculoRepository.Existe(id);
            if (resultado)
                Log.Information("{DataEHora} / GrupoDeVeiculos {Id} encontrado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: AppService / Módulo: Existe / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), id);
            return resultado;
        }
        public override GrupoDeVeiculo SelecionarEntidadePorId(int id)
        {
            return grupoDeVeiculoRepository.SelecionarPorId(id);
        }
        public override List<GrupoDeVeiculo> SelecionarTodasEntidade()
        {
            return grupoDeVeiculoRepository.SelecionarTodos();
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
