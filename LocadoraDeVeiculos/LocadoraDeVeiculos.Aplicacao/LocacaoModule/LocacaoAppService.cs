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
                Log.Information("{DataEHora} / Locação {locacao} adicionado com sucesso", DateTime.Now, locacao);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Inserir", locacao);

            return resultado;
        }
        public override bool EditarEntidade(int id, Locacao locacao)
        {
            bool resultado = locacaoRepository.Editar(id, locacao);
            if (resultado)
                Log.Information("{DataEHora} / Locação {locacao} adicionado com sucesso", DateTime.Now, locacao);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Inserir", locacao);
            return resultado;
        }
        public override bool ExcluirEntidade(int id)
        {
            bool resultado = locacaoRepository.Excluir(id);

            if (resultado)
                Log.Information("{DataEHora} / Id {id} adicionado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Inserir", id);

            return resultado;
        }
        public override Locacao SelecionarEntidadePorId(int id)
        {
            return locacaoRepository.SelecionarPorId(id);
        }
        public override List<Locacao> SelecionarTodasEntidade()
        {
            return locacaoRepository.SelecionarTodos();
        }
        public override bool ExisteEntidade(int id)
        {
            return locacaoRepository.Existe(id);
        }
    }
}
