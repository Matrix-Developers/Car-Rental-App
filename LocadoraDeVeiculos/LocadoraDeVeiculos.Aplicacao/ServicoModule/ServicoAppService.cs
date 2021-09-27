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

        public ServicoAppService(IRepository<Servico> servicoRepository)
        {
            this.servicoRepository = servicoRepository;
        }

        public override bool InserirEntidade(Servico servico)
        {
            bool resultadoValidacao = servicoRepository.InserirNovo(servico);
            if (resultadoValidacao)
                Log.Information("{DataEHora} / Servico {Servico} adicionado com sucesso", DateTime.Now, servico);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Inserir", servico);
            return resultadoValidacao;
        }
        public override bool EditarEntidade(int id, Servico servico)
        {
            bool resultadoValidacao = servicoRepository.Editar(id, servico);
            if (resultadoValidacao)
                Log.Information("{DataEHora} / Parceiro {Servico} editado com sucesso", DateTime.Now, servico);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Editar", servico);
            return resultadoValidacao;
        }
        public override bool ExcluirEntidade(int id)
        {
            GeradorLog.ConfigurarLog();
            bool resultado = servicoRepository.Excluir(id);
            if (resultado)
                Log.Information("{DataEHora} / Serviço {Id} excluido com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Excluir", id);
            return resultado;
        }
        public override bool ExisteEntidade(int id)
        {
            bool resultado = servicoRepository.Existe(id);
            if (resultado)
                Log.Information("{DataEHora} / Serviço {Id} encontrado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Existe Entidade", id);
            return resultado;
        }
        public override Servico SelecionarEntidadePorId(int id)
        {
            Servico servico = servicoRepository.SelecionarPorId(id);
            if (servico != null)
                Log.Information("{DataEHora} / Serviço {Id} selecionado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Selecionar Por Id", id);
            return servico;
        }
        public override List<Servico> SelecionarTodasEntidade()
        {
            List<Servico> listServico = servicoRepository.SelecionarTodos();
            if (listServico != null)
                Log.Information("{DataEHora} / {QtdSelecionados} Serviços selecionados com sucesso", DateTime.Now, listServico.Count);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Selecionar Todos");
            return listServico;
        }
    }
}
