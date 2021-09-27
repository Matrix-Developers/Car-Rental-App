using LocadoraDeVeiculos.Aplicacao.Shared;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Infra.Logs;
using Serilog;
using System;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Aplicacao.CupomModule
{
    public class CupomAppService : AppServiceBase<Cupom>
    {
        private readonly ICupomRepository cupomRepository;

        public CupomAppService(ICupomRepository cupomRepository)
        {
            this.cupomRepository = cupomRepository;
        }

        public override bool InserirEntidade(Cupom cupom)
        {
            GeradorLog.ConfigurarLog();
            bool resultado = cupomRepository.InserirNovo(cupom);
            if (resultado)
                Log.Information("{DataEHora} / Cupom {Cupom} adicionado com sucesso", DateTime.Now, cupom);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Inserir", cupom);

            return resultado;
        }
        public override bool EditarEntidade(int id, Cupom cupom)
        {
            GeradorLog.ConfigurarLog();
            bool resultado = cupomRepository.Editar(id, cupom);
            if (resultado)
                Log.Information("{DataEHora} / Cupom {Cupom} editado com sucesso", DateTime.Now, id, cupom);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Editar", cupom);

            return resultado;
        }
        public override bool ExcluirEntidade(int id)
        {
            GeradorLog.ConfigurarLog();
            bool resultado = cupomRepository.Excluir(id);
            if (resultado)
                Log.Information("{DataEHora} / Cupom {Cupom} excluido com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Excluir", id);


            return resultado;
        }
        public override bool ExisteEntidade(int id)
        {
            GeradorLog.ConfigurarLog();

            bool resultado = cupomRepository.Existe(id);
            if (resultado)
                Log.Information("{DataEHora} / Cupom {Cupom} existe com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Existe", id);

            return resultado;
        }
        public override Cupom SelecionarEntidadePorId(int id)
        {
            Cupom cupom;
            cupom = cupomRepository.SelecionarPorId(id);
            if (cupom != null)
                Log.Information("{DataEHora} / Cupom {Cupom} selecionado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Selecionar por Id", id);
            return cupom;
        }
        public override List<Cupom> SelecionarTodasEntidade()
        {
            List<Cupom> listCupom = cupomRepository.SelecionarTodos();
            if (listCupom != null)
                Log.Information("{DataEHora} / {QtdSelecionados} Cupons selecionados com sucesso", DateTime.Now, listCupom.Count);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Selecionar Todos");
            return listCupom;
        }


        public bool ExisteCodigo(string codigo)
        {
            bool resultado = cupomRepository.ExisteCodigo(codigo);
            if (resultado)
                Log.Information("{DataEHora} / Cupom {Cupom} existe código com sucesso", DateTime.Now, codigo);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Existe Codigo", codigo);
            return resultado;
        }

        public Cupom SelecionarPorCodigo(string codigo)
        {
            Cupom cupom;
            cupom = cupomRepository.SelecionarPorCodigo(codigo);
            if(cupom != null)
                Log.Information("{DataEHora} / Cupom {Cupom} selecionado por código com sucesso", DateTime.Now, codigo);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Selecionar por codigo", codigo);


            return cupomRepository.SelecionarPorCodigo(codigo);
        }

        public void AtualizarQuantidadeUtilizada(int id, int quantidade)
        {
            try
            {
            cupomRepository.AtualizarQtdUtilizada(id, quantidade);

            }
            catch (Exception)
            {
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Atualizar Qtd Utilizada", id, quantidade);
            }
        }
    }
}
