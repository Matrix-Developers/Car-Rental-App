using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.Logs;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data;

namespace LocadoraDeVeiculos.Infra.SQL.Shared
{
    public abstract class RepositoryBase<T> where T : EntidadeBase
    {
        protected abstract string SqlInserirEntidade { get; }
        protected abstract string SqlEditarEntidade { get; }
        protected abstract string SqlExcluirEntidade { get; }
        protected abstract string SqlSelecionarEntidadePorId { get; }
        protected abstract string SqlSelecionarTodasEntidades { get; }
        protected abstract string SqlExisteEntidade { get; }

        public bool InserirNovo(T registro)
        {
            try
            {
                registro.Id = Db.Insert(SqlInserirEntidade, ObtemParametros(registro));
            }
            catch (Exception ex)
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Inserir um(a) novo(a) {Feature} / Camada: Repository / Usuário: IdUsuario Tempo: ?? / Sql: {query} / {StackTrace}", DateTime.Now, this.ToString(), SqlInserirEntidade, ex);
                return false;
            }
            return true;
        }
        public bool Editar(int id, T registro)
        {
            try
            {
                registro.Id = id;
                Db.Update(SqlEditarEntidade, ObtemParametros(registro));
            }
            catch (Exception ex)
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Editar  um(a) {Feature} / Camada: Repository / Id Processo: {IdProcesso} / Usuário: IdUsuario Tempo: ?? / Sql: {query} / {StackTrace}", DateTime.Now, this.ToString(), id, SqlEditarEntidade, ex);
                return false;
            }
            return true;
        }
        public bool Excluir(int id)
        {
            GeradorLog.ConfigurarLog();
            try
            {
                Db.Delete(SqlExcluirEntidade, AdicionarParametro("ID", id));
            }
            catch (Exception ex)
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Excluir um(a) {Feature} / Camada: Repository / Id Processo: {IdProcesso} / Usuário: IdUsuario Tempo: ?? / Sql: {query} / {StackTrace}", DateTime.Now, this.ToString(), id, SqlExcluirEntidade, ex);
                return false;
            }

            return true;
        }
        public T SelecionarPorId(int id)
        {
            try
            {
                return Db.Get(SqlSelecionarEntidadePorId, ConverterEmEntidade, AdicionarParametro("ID", id));
            }
            catch (Exception ex)
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Selecionar Por Id um(a) {Feature} / Camada: Repository / Id Processo: {IdProcesso} / Usuário: IdUsuario Tempo: ?? / Sql: {query} / {StackTrace}", DateTime.Now, this.ToString(), id, SqlSelecionarEntidadePorId, ex);
                return null;
            }
            
        }
        public List<T> SelecionarTodos()
        {
            try
            {
                return Db.GetAll(SqlSelecionarTodasEntidades, ConverterEmEntidade);
            }
            catch (Exception ex)
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Selecionar Todos um(a) {Feature} / Camada: Repository / Usuário: IdUsuario Tempo: ?? / Sql: {query} / {StackTrace}", DateTime.Now, this.ToString(), SqlSelecionarTodasEntidades, ex);
                return null;
            }
        }
        public bool Existe(int id)
        {
            try
            {
                return Db.Exists(SqlExisteEntidade, AdicionarParametro("ID", id));
            }
            catch (Exception ex)
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Verificar se Existe o(a) {Feature} / Camada: Repository / Usuário: IdUsuario Tempo: ?? / Sql: {query} / {StackTrace}", DateTime.Now, this.ToString(), SqlExisteEntidade, ex);
                return false;
            }
            
        }

        protected static Dictionary<string, object> AdicionarParametro(string campo, object valor)
        {
            return new Dictionary<string, object>() { { campo, valor } };
        }

        protected abstract Dictionary<string, object> ObtemParametros(T entidade);
        protected abstract T ConverterEmEntidade(IDataReader reader);
    }
}
