using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.EntityFramework.Shared;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Features
{
    public class LocacaoORM : RepositoryBase<Locacao>, IRepository<Locacao>
    {
        public LocacaoORM(LocadoraDeVeiculosDBContext db) : base(db)
        {
        }
    }
}
