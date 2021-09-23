using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Aplicacao.Shared
{
    public abstract class AppServiceBase<T> where T : EntidadeBase
    {
        public abstract string InserirEntidade(T entidade);
        public abstract string EditarEntidade(int id, T entidade);
        public abstract bool ExcluirEntidade(int id);
        public abstract bool ExisteEntidade(int id);
        public abstract T SelecionarEntidadePorId(int id);
        public abstract List<T> SelecionarTodasEntidade();
    }
}
