using LocadoraDeVeiculos.Dominio.Shared;
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

        protected abstract Dictionary<string, object> ObtemParametros(T entidade);
        protected abstract T ConverterEmEntidade(IDataReader reader);
        protected static Dictionary<string, object> AdicionarParametro(string campo, object valor)
        {
            return new Dictionary<string, object>() { { campo, valor } };
        }
    }
}
