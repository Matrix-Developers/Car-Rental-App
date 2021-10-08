using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.EntityFramework.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Features
{
    public class ServicoORM : RepositoryBase<Servico>, IRepository<Servico>
    {
        public ServicoORM(LocadoraDeVeiculosDBContext db) : base(db)
        {
        }
    }
}
