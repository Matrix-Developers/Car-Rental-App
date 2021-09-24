using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.Shared
{
    public interface IRepository<T> where T : EntidadeBase
    {
        bool InserirNovo(T registro);
        bool Editar(int id, T registro);
        bool Existe(int id);
        bool Excluir(int id);
        List<T> SelecionarTodos();
        T SelecionarPorId(int id);
    }
}
