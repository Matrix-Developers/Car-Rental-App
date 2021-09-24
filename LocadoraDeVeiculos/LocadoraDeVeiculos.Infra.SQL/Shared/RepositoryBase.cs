using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.Shared;
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
                return false;
            }
            return true;
        }
        public bool Excluir(int id)
        {
            try
            {
                Db.Delete(SqlExcluirEntidade, AdicionarParametro("ID", id));
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
        public T SelecionarPorId(int id)
        {
            return Db.Get(SqlSelecionarEntidadePorId, ConverterEmEntidade, AdicionarParametro("ID", id));
        }
        public List<T> SelecionarTodos()
        {
            return Db.GetAll(SqlSelecionarTodasEntidades, ConverterEmEntidade);
        }
        public bool Existe(int id)
        {
            return Db.Exists(SqlExisteEntidade, AdicionarParametro("ID", id));
        }

        protected static Dictionary<string, object> AdicionarParametro(string campo, object valor)
        {
            return new Dictionary<string, object>() { { campo, valor } };
        }

        protected abstract Dictionary<string, object> ObtemParametros(T entidade);
        protected abstract T ConverterEmEntidade(IDataReader reader);
    }
}
