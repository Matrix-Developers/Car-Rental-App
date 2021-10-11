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
        private long tempo;

        public CupomAppService(ICupomRepository cupomRepository)
        {
            this.cupomRepository = cupomRepository;
        }

        public override bool InserirEntidade(Cupom cupom)
        {
            GeradorLog.ConfigurarLog();
            tempo = DateTime.Now.Millisecond;
            bool resultado = cupomRepository.InserirNovo(cupom);
            tempo = DateTime.Now.Millisecond - tempo;

            if (resultado)
                Log.Information("{DataEHora} / Cupom {Cupom} adicionado com sucesso", DateTime.Now, cupom);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Inserir", cupom, tempo);

            return resultado;
        }
        public override bool EditarEntidade(int id, Cupom cupom)
        {
            GeradorLog.ConfigurarLog();
            tempo = DateTime.Now.Millisecond;
            bool resultado = cupomRepository.Editar(id, cupom);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Cupom {Cupom} editado com sucesso", DateTime.Now, id, cupom);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Editar", cupom, tempo);

            return resultado;
        }
        public override bool ExcluirEntidade(int id)
        {
            GeradorLog.ConfigurarLog();
            tempo = DateTime.Now.Millisecond;
            bool resultado = cupomRepository.Excluir(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Cupom {Cupom} excluido com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Excluir", id, tempo);


            return resultado;
        }
        public override bool ExisteEntidade(int id)
        {
            GeradorLog.ConfigurarLog();
            tempo = DateTime.Now.Millisecond;
            bool resultado = cupomRepository.Existe(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Cupom {Cupom} existe com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Existe", id, tempo);

            return resultado;
        }
        public override Cupom SelecionarEntidadePorId(int id)
        {
            Cupom cupom;
            tempo = DateTime.Now.Millisecond;
            cupom = cupomRepository.SelecionarPorId(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (cupom != null)
                Log.Information("{DataEHora} / Cupom {Cupom} selecionado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Selecionar por Id", id, tempo);
            return cupom;
        }
        public override List<Cupom> SelecionarTodasEntidade()
        {
            tempo = DateTime.Now.Millisecond;
            List<Cupom> listCupom = cupomRepository.SelecionarTodos();
            tempo = DateTime.Now.Millisecond - tempo;
            if (listCupom != null)
                Log.Information("{DataEHora} / {QtdSelecionados} Cupons selecionados com sucesso", DateTime.Now, listCupom.Count);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Selecionar Todos", tempo);
            return listCupom;
        }


        public bool ExisteCodigo(string codigo)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = cupomRepository.ExisteCodigo(codigo);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Cupom {Cupom} existe código com sucesso", DateTime.Now, codigo);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: {Tempo}", DateTime.Now, this.ToString(), "AppService", "Existe Codigo", codigo, tempo);
            return resultado;
        }

        public Cupom SelecionarPorCodigo(string codigo)
        {
            Cupom cupom;
            tempo = DateTime.Now.Millisecond;
            cupom = cupomRepository.SelecionarPorCodigo(codigo);
            tempo = DateTime.Now.Millisecond - tempo;
            if (cupom != null)
                Log.Information("{DataEHora} / Cupom {Cupom} selecionado por código com sucesso", DateTime.Now, codigo);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: {Tempo}", DateTime.Now, this.ToString(), "AppService", "Selecionar por codigo", codigo, tempo);


            return cupomRepository.SelecionarPorCodigo(codigo);
        }

        public void AtualizarQuantidadeUtilizada(Cupom cupom)
        {
            try
            {
                tempo = DateTime.Now.Millisecond;
                cupomRepository.AtualizarQtdUtilizada(cupom);
                tempo = DateTime.Now.Millisecond - tempo;
            }
            catch (Exception)
            {
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: {Tempo}", DateTime.Now, this.ToString(), "AppService", "Atualizar Qtd Utilizada", cupom.Id, cupom.QtdUtilizada, tempo);
            }
        }
    }
}
