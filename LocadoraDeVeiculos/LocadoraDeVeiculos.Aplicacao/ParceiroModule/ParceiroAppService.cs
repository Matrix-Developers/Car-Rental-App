using LocadoraDeVeiculos.Aplicacao.Shared;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;
using LocadoraDeVeiculos.Infra.Logs;
using System;
using Serilog;

namespace LocadoraDeVeiculos.Aplicacao.ParceiroModule
{
    public class ParceiroAppService : AppServiceBase<Parceiro>
    {
        private readonly IRepository<Parceiro> parceiroRepository;

        public ParceiroAppService(IRepository<Parceiro> parceiroRepository)
        {
            this.parceiroRepository = parceiroRepository;
        }

        public override bool InserirEntidade(Parceiro parceiro)
        {
            bool resultado = parceiroRepository.InserirNovo(parceiro);

            if (resultado)
                Log.Information("{DataEHora} / Parceiro {Parceiro} adicionado com sucesso", DateTime.Now, parceiro);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Inserir", parceiro);
            return resultado;
        }
        public override bool EditarEntidade(int id, Parceiro parceiro)
        {
            bool resultado = parceiroRepository.Editar(id, parceiro);

            return resultado;
        }
        public override bool ExcluirEntidade(int id)
        {
            GeradorLog.ConfigurarLog();
            bool resultado = parceiroRepository.Excluir(id);
            if (resultado)
                Log.Information("{DataEHora} / Parceiro {Id} excluido com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: Excluir / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", id);
            return resultado;
        }
        public override bool ExisteEntidade(int id)
        {
            return parceiroRepository.Existe(id);
        }
        public override Parceiro SelecionarEntidadePorId(int id)
        {
            return parceiroRepository.SelecionarPorId(id);
        }
        public override List<Parceiro> SelecionarTodasEntidade()
        {
            return parceiroRepository.SelecionarTodos();
        }
    }
}
