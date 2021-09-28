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
        long tempo;

        public ParceiroAppService(IRepository<Parceiro> parceiroRepository)
        {
            this.parceiroRepository = parceiroRepository;
        }

        public override bool InserirEntidade(Parceiro parceiro)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = parceiroRepository.InserirNovo(parceiro);
            tempo = DateTime.Now.Millisecond - tempo;

            if (resultado)
                Log.Information("{DataEHora} / Parceiro {Parceiro} adicionado com sucesso", DateTime.Now, parceiro);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Registro: {Id}", DateTime.Now, this.ToString(), "AppService", "Inserir", parceiro,tempo);
            return resultado;
        }
        public override bool EditarEntidade(int id, Parceiro parceiro)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = parceiroRepository.Editar(id, parceiro);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Parceiro {Parceiro} editado com sucesso", DateTime.Now, parceiro);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Registro: {Id}", DateTime.Now, this.ToString(), "AppService", "Editar", parceiro,tempo);
            return resultado;
        }
        public override bool ExcluirEntidade(int id)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = parceiroRepository.Excluir(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Parceiro {Id} excluido com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {Id}", DateTime.Now, this.ToString(), "AppService", "Excluir", id,tempo);
            return resultado;
        }
        public override bool ExisteEntidade(int id)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = parceiroRepository.Existe(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Parceiro {Id} encontrado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {Id} ", DateTime.Now, this.ToString(), "AppService", "Existe Entidade", id,tempo);
            return resultado;
        }
        public override Parceiro SelecionarEntidadePorId(int id)
        {
            tempo = DateTime.Now.Millisecond;
            Parceiro parceiro;
            parceiro = parceiroRepository.SelecionarPorId(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if(parceiro != null)
                Log.Information("{DataEHora} / Existe {Id} selecionado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {Id}", DateTime.Now, this.ToString(), "AppService", "Selecionar Por Id", id,tempo);
            return parceiro;
        }
        public override List<Parceiro> SelecionarTodasEntidade()
        {
            tempo = DateTime.Now.Millisecond;
            List<Parceiro> listParceiro = parceiroRepository.SelecionarTodos();
            tempo = DateTime.Now.Millisecond - tempo;
            if(listParceiro != null)
                Log.Information("{DataEHora} / {QtdSelecionados} Parceiros selecionados com sucesso", DateTime.Now, listParceiro.Count);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} ", DateTime.Now, this.ToString(), "AppService", "Selecionar Todos",tempo);
            return listParceiro;
        }
    }
}
