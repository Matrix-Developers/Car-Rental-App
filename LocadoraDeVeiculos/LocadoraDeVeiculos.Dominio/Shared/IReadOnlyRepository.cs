using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.Shared
{
    public interface IReadOnlyRepository<TEntity, TKey>
    {
        List<TEntity> SelecionarTodos();
        TEntity SelecionarPorId(TKey id);
        bool Existe(TKey id);
    }
}
