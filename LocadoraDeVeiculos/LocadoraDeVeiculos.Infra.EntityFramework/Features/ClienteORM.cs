using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.EntityFramework.Shared;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Features
{
    public class ClienteORM : RepositoryBase<Cliente>, IRepository<Cliente>
    {
        public ClienteORM(LocadoraDeVeiculosDBContext db) : base(db)
        {
        }
    }
}
