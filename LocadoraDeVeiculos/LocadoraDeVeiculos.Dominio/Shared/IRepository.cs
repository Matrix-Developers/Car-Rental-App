using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
