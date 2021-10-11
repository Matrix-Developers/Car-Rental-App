using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.EntityFramework.Shared;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Features
{
    public class GrupoDeVeiculosORM : RepositoryBase<GrupoDeVeiculo>, IRepository<GrupoDeVeiculo>
    {
        public GrupoDeVeiculosORM(LocadoraDeVeiculosDBContext db) : base(db)
        {
        }
    }
}
