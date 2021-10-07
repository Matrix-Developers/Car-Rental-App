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
        private readonly IRepository<Funcionario, int> funcionarioRepository;
        private readonly IReadOnlyRepository<Funcionario, int> funcionarioLeitura;
        private long tempo;
        public FuncionarioAppService(IRepository<Funcionario, int> funcionarioRepository, IReadOnlyRepository<Funcionario, int> funcionarioLeitura)
        {
            this.funcionarioRepository = funcionarioRepository;
            this.funcionarioLeitura = funcionarioLeitura;
        }

        public override bool InserirEntidade(Funcionario funcionario)
        {
            GeradorLog.ConfigurarLog();
            tempo = DateTime.Now.Millisecond;
            bool resultado = funcionarioRepository.InserirNovo(funcionario);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Funcionario {Funcionario} adicionado com sucesso", DateTime.Now, funcionario);
            else 
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {id} / Tempo total: {Tempo}", DateTime.Now, this.ToString(), "AppService", "Inserir", funcionario, tempo);
            return resultado;
        }
        public override bool EditarEntidade(int id, Funcionario funcionario)
        {
            GeradorLog.ConfigurarLog();
            tempo = DateTime.Now.Millisecond;
            bool resultado = funcionarioRepository.Editar(id, funcionario);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Funcionario {Funcionario} editado com sucesso", DateTime.Now, id,funcionario);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Editar", funcionario, tempo);
            return resultado;
        }
        public override bool ExcluirEntidade(int id)
        {
            GeradorLog.ConfigurarLog();
            tempo = DateTime.Now.Millisecond;
            bool resultado = funcionarioRepository.Excluir(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Funcionario {Funcionario} excluido com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Excluir", id, tempo);

            return resultado;
        }
        public override bool ExisteEntidade(int id)
        {
            GeradorLog.ConfigurarLog();
            tempo = DateTime.Now.Millisecond;
            bool resultado =  funcionarioLeitura.Existe(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Funcionario {Funcionario} existe com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Existe", id, tempo);

            return resultado;
        }
        public override Funcionario SelecionarEntidadePorId(int id)
        {
            Funcionario funcionario;
            tempo = DateTime.Now.Millisecond;
            funcionario = funcionarioLeitura.SelecionarPorId(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (funcionario != null)
                Log.Information("{DataEHora} / Funcionario {Funcionario} selecionado por id com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Selecionar Por id", id, tempo);
            return funcionario;
        }
        public override List<Funcionario> SelecionarTodasEntidade()
        {
            tempo = DateTime.Now.Millisecond;
            List<Funcionario> listFuncionario = funcionarioLeitura.SelecionarTodos();
            tempo = DateTime.Now.Millisecond - tempo;
            if (listFuncionario != null)
                if (listFuncionario != null)
                    Log.Information("{DataEHora} / Funcionario {Funcionario} selecionados com sucesso", DateTime.Now, listFuncionario.Count);
                else
                    Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Selecionar Todos", tempo);

            return listFuncionario;
        }
    }
}
