using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.EntityFramework.Shared;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Features
{
    public class ParceiroORM : RepositoryBase<Parceiro>, IRepository<Parceiro>
    {
        public ParceiroORM(LocadoraDeVeiculosDBContext db) : base(db)
        {
        }
    }
}
