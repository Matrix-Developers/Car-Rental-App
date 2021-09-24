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

        public override string InserirEntidade(Parceiro parceiro)
        {
            string ResultadoValidacao = parceiro.Validar();

            if (ResultadoValidacao == "VALIDO")
                parceiroRepository.InserirNovo(parceiro);

            return ResultadoValidacao;
        }
        public override string EditarEntidade(int id, Parceiro parceiro)
        {
            string ResultadoValidacao = parceiro.Validar();

            if (ResultadoValidacao == "VALIDO")
                parceiroRepository.Editar(id, parceiro);

            return ResultadoValidacao;
        }
        public override bool ExcluirEntidade(int id)
        {
            GeradorLog.ConfigurarLog();
            bool resultado = parceiroRepository.Excluir(id);
            if (resultado)                
                Log.Information("Id : {id}", id);
            else
                Log.Error($"{DateTime.Now} / Feature: Parceiro / Camada: AppService / Módulo: Excluir / ID Registro: {id} / Tempo total: ?????", "Error");
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
