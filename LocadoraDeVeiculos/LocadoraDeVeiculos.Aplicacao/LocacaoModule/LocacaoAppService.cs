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

        public LocacaoAppService(IRepository<Locacao> locacaoRepository)
        {
            this.locacaoRepository = locacaoRepository;
        }

        public override bool InserirEntidade(Locacao locacao)
        {
            bool resultado = locacaoRepository.InserirNovo(locacao);
            if (resultado)
                Log.Information("{DataEHora} / Locação {locacao} Adicionado com sucesso", DateTime.Now, locacao);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Inserir", locacao);

            return resultado;
        }
        public override bool EditarEntidade(int id, Locacao locacao)
        {
            bool resultado = locacaoRepository.Editar(id, locacao);
            if (resultado)
                Log.Information("{DataEHora} / Locação {locacao} Editado com sucesso", DateTime.Now, locacao);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Inserir", locacao);
            return resultado;
        }
        public override bool ExcluirEntidade(int id)
        {
            bool resultado = locacaoRepository.Excluir(id);

            if (resultado)
                Log.Information("{DataEHora} / Id {id} Excluido com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Inserir", id);

            return resultado;
        }
        public override Locacao SelecionarEntidadePorId(int id)
        {
            Locacao locacao = locacaoRepository.SelecionarPorId(id);

            if(locacao != null)
                Log.Information("{DataEHora} / Locação {id} selecionado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Selecionar por id", id);

            return locacao;
        }
        public override List<Locacao> SelecionarTodasEntidade()
        {
            List<Locacao> locacoes = locacaoRepository.SelecionarTodos();

            if (locacoes != null)
                Log.Information("{DataEHora} / Locações {id} Selecionadas com sucesso", DateTime.Now, locacoes.Count);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Selecionar todos", locacoes.Count);

            return locacoes;
        }
        public override bool ExisteEntidade(int id)
        {
            return locacaoRepository.Existe(id);
        }
    }
}
