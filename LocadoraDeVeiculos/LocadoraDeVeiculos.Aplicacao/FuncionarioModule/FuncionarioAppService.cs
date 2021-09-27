using LocadoraDeVeiculos.Aplicacao.Shared;
using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.Logs;
using Serilog;
using System;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Aplicacao.FuncionarioModule
{
    public class FuncionarioAppService : AppServiceBase<Funcionario>
    {
        private readonly IRepository<Funcionario> funcionarioRepository;

        public FuncionarioAppService(IRepository<Funcionario> funcionarioRepository)
        {
            this.funcionarioRepository = funcionarioRepository;
        }

        public override bool InserirEntidade(Funcionario funcionario)
        {
            GeradorLog.ConfigurarLog();
            bool resultado = funcionarioRepository.InserirNovo(funcionario);
            if (resultado)
                Log.Information("{DataEHora} / Funcionario {Funcionario} adicionado com sucesso", DateTime.Now, funcionario);
            else 
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Inserir", funcionario);
            return resultado;
        }
        public override bool EditarEntidade(int id, Funcionario funcionario)
        {
            GeradorLog.ConfigurarLog();
            bool resultado = funcionarioRepository.Editar(id, funcionario);
            if (resultado)
                Log.Information("{DataEHora} / Funcionario {Funcionario} editado com sucesso", DateTime.Now, id,funcionario);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Editar", funcionario);
            return resultado;
        }
        public override bool ExcluirEntidade(int id)
        {
            GeradorLog.ConfigurarLog();
            bool resultado = funcionarioRepository.Excluir(id);
            if (resultado)
                Log.Information("{DataEHora} / Funcionario {Funcionario} excluido com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Excluir", id);

            return resultado;
        }
        public override bool ExisteEntidade(int id)
        {
            GeradorLog.ConfigurarLog();
            bool resultado =  funcionarioRepository.Existe(id);
            if (resultado)
                Log.Information("{DataEHora} / Funcionario {Funcionario} existe com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Existe", id);

            return resultado;
        }
        public override Funcionario SelecionarEntidadePorId(int id)
        {
            Funcionario funcionario;
            funcionario =  funcionarioRepository.SelecionarPorId(id);
            if(funcionario != null)
                Log.Information("{DataEHora} / Funcionario {Funcionario} selecionado por id com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Selecionar Por Id", id);
            return funcionario;
        }
        public override List<Funcionario> SelecionarTodasEntidade()
        {
            List<Funcionario> listFuncionario = funcionarioRepository.SelecionarTodos();
            if (listFuncionario != null)
                if (listFuncionario != null)
                    Log.Information("{DataEHora} / Funcionario {Funcionario} selecionados com sucesso", DateTime.Now, listFuncionario.Count);
                else
                    Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Selecionar Todos");

            return listFuncionario;
        }
    }
}
