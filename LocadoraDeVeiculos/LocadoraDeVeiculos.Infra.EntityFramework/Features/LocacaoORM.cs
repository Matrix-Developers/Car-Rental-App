using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.EntityFramework.Shared;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Features
{
    public class LocacaoORM : RepositoryBase<Locacao>, IRepository<Locacao>
    {
        public LocacaoORM(LocadoraDeVeiculosDBContext db) : base(db)
        {
        }

        public override Locacao SelecionarPorId(int id)
        {
            return db.Locacoes
                .Include(x => x.FuncionarioLocador)
                .Include(x => x.Servicos)
                .Include(x => x.Veiculo)
                .ThenInclude(x => x.grupoVeiculos)
                .SingleOrDefault(x => x.Id == id);
        }
    }
}
