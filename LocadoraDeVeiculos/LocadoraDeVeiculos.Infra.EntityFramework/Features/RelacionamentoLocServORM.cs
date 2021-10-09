using LocadoraDeVeiculos.Dominio.RelacionamentoLocServModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.EntityFramework.Shared;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Features
{
    class RelacionamentoLocServORM : RepositoryBase<RelacionamentoLocServ>, IRepository<RelacionamentoLocServ>
    {
        public RelacionamentoLocServORM(LocadoraDeVeiculosDBContext db) : base(db)
        {
        }
    }
}
