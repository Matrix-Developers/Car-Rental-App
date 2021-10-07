using LocadoraDeVeiculos.Aplicacao.Shared;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.Shared;
using Serilog;
using System;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Aplicacao.LocacaoModule
{
    public class LocacaoAppService : AppServiceBase<Locacao>
    {
        private readonly IRepository<Locacao> locacaoRepository;
        long tempo;
        public LocacaoAppService(IRepository<Locacao> locacaoRepository)
        {
            this.locacaoRepository = locacaoRepository;
        }

        public override bool InserirEntidade(Locacao locacao)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = locacaoRepository.InserirNovo(locacao);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Locação {locacao} Adicionado com sucesso", DateTime.Now, locacao);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {id} {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Inserir", locacao,tempo);

            return resultado;
        }
        public override bool EditarEntidade(int id, Locacao locacao)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = locacaoRepository.Editar(id, locacao);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Locação {locacao} Editado com sucesso", DateTime.Now, locacao);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {id} {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Inserir", locacao,tempo);
            return resultado;
        }
        public override bool ExcluirEntidade(int id)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = locacaoRepository.Excluir(id);
            tempo = DateTime.Now.Millisecond - tempo;

            if (resultado)
                Log.Information("{DataEHora} / id {id} Excluido com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {id} {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Inserir", id,tempo);

            return resultado;
        }
        public override Locacao SelecionarEntidadePorId(int id)
        {
            tempo = DateTime.Now.Millisecond;
            Locacao locacao = locacaoRepository.SelecionarPorId(id);
            tempo = DateTime.Now.Millisecond - tempo;

            if(locacao != null)
                Log.Information("{DataEHora} / Locação {id} selecionado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {id} {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Selecionar por id", id,tempo);

            return locacao;
        }
        public override List<Locacao> SelecionarTodasEntidade()
        {
            tempo = DateTime.Now.Millisecond;
            List<Locacao> locacoes = locacaoRepository.SelecionarTodos();
            tempo = DateTime.Now.Millisecond - tempo;

            if (locacoes != null)
                Log.Information("{DataEHora} / Locações {id} Selecionadas com sucesso", DateTime.Now, locacoes.Count);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {id} {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Selecionar todos", locacoes.Count,tempo);

            return locacoes;
        }
        public override bool ExisteEntidade(int id)
        {
            return locacaoRepository.Existe(id);
        }
    }
}
