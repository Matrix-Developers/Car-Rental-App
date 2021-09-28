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
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Inserir", parceiro);
            return resultado;
        }
        public override bool EditarEntidade(int id, Parceiro parceiro)
        {
            bool resultado = parceiroRepository.Editar(id, parceiro);
            if (resultado)
                Log.Information("{DataEHora} / Parceiro {Parceiro} editado com sucesso", DateTime.Now, parceiro);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Editar", parceiro);
            return resultado;
        }
        public override bool ExcluirEntidade(int id)
        {
            bool resultado = parceiroRepository.Excluir(id);
            if (resultado)
                Log.Information("{DataEHora} / Parceiro {Id} excluido com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Excluir", id);
            return resultado;
        }
        public override bool ExisteEntidade(int id)
        {
            bool resultado = parceiroRepository.Existe(id);
            if (resultado)
                Log.Information("{DataEHora} / Parceiro {Id} encontrado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Existe Entidade", id);
            return resultado;
        }
        public override Parceiro SelecionarEntidadePorId(int id)
        {
            Parceiro parceiro;
            parceiro = parceiroRepository.SelecionarPorId(id);
            if(parceiro != null)
                Log.Information("{DataEHora} / Existe {Id} selecionado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Selecionar Por Id", id);
            return parceiro;
        }
        public override List<Parceiro> SelecionarTodasEntidade()
        {
            List<Parceiro> listParceiro = parceiroRepository.SelecionarTodos();
            if(listParceiro != null)
                Log.Information("{DataEHora} / {QtdSelecionados} Parceiros selecionados com sucesso", DateTime.Now, listParceiro.Count);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Selecionar Todos");
            return listParceiro;
        }
    }
}
