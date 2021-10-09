using LocadoraDeVeiculos.Dominio.VeiculoModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.EntityFramework.Shared;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Features
{
    public class VeiculoORM : RepositoryBase<Veiculo>, IRepository<Veiculo>
    {
        public VeiculoORM(LocadoraDeVeiculosDBContext db) : base(db)
        {
        }
    }
}
