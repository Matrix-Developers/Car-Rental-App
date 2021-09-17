using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.Shared
{
    public interface IRepository<T> where T : EntidadeBase
    {
        string InserirNovo(T registro);
        string Editar(int id, T registro);
        bool Existe(int id);
        bool Excluir(int id);
        List<T> SelecionarTodos();
        T SelecionarPorId(int id);
    }
}
