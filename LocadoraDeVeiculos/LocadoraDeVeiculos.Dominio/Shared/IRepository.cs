using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.Shared
{
    public interface IRepository<EntidadeBase, TKey>
    {
        bool InserirNovo(EntidadeBase registro);
        bool Editar(int id, EntidadeBase registro);
        bool Excluir(int id);        
    }
}
