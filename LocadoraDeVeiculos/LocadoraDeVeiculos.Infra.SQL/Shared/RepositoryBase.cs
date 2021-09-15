using LocadoraDeVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Infra.SQL.Shared
{
    public abstract class RepositoryBase <T> where T : EntidadeBase
    {
        protected abstract Dictionary<string, object> ObtemParametros(T entidade);
        protected abstract T ConverterEmEntidade(IDataReader reader);
        protected static Dictionary<string, object> AdicionarParametro(string campo, object valor)
        {
            return new Dictionary<string, object>() { { campo, valor } };
        }
    }
}
