using LocadoraDeVeiculos.Aplicacao.Shared;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.Logs;
using Serilog;
using System;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Aplicacao.ServicoModule
{
    public class ServicoAppService : AppServiceBase<Servico>
    {
        private readonly IRepository<Servico> servicoRepository;
        long tempo;

        public ServicoAppService(IRepository<Servico> servicoRepository)
        {
            this.servicoRepository = servicoRepository;
        }

        public override bool InserirEntidade(Servico servico)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultadoValidacao = servicoRepository.InserirNovo(servico);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultadoValidacao)
                Log.Information("{DataEHora} / Servico {Servico} adicionado com sucesso", DateTime.Now, servico);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Inserir", servico,tempo);
            return resultadoValidacao;
        }
        public override bool EditarEntidade(int id, Servico servico)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultadoValidacao = servicoRepository.Editar(id, servico);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultadoValidacao)
                Log.Information("{DataEHora} / Parceiro {Servico} editado com sucesso", DateTime.Now, servico);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Editar", servico,tempo);
            return resultadoValidacao;
        }
        public override bool ExcluirEntidade(int id)
        {
            GeradorLog.ConfigurarLog();
            tempo = DateTime.Now.Millisecond;
            bool resultado = servicoRepository.Excluir(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Serviço {Id} excluido com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Excluir", id,tempo);
            return resultado;
        }
        public override bool ExisteEntidade(int id)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = servicoRepository.Existe(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Serviço {Id} encontrado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Existe Entidade", id,tempo);
            return resultado;
        }
        public override Servico SelecionarEntidadePorId(int id)
        {
            tempo = DateTime.Now.Millisecond;
            Servico servico = servicoRepository.SelecionarPorId(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (servico != null)
                Log.Information("{DataEHora} / Serviço {Id} selecionado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Selecionar Por Id", id,tempo);
            return servico;
        }
        public override List<Servico> SelecionarTodasEntidade()
        {
            tempo = DateTime.Now.Millisecond;
            List<Servico> listServico = servicoRepository.SelecionarTodos();
            tempo = DateTime.Now.Millisecond - tempo;
            if (listServico != null)
                Log.Information("{DataEHora} / {QtdSelecionados} Serviços selecionados com sucesso", DateTime.Now, listServico.Count);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Selecionar Todos",tempo);
            return listServico;
        }
    }
}
