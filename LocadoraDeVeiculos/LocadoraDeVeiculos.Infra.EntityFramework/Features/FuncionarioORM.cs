using LocadoraDeVeiculos.Dominio.FuncionarioModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.EntityFramework.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Features
{
    public class FuncionarioORM : RepositoryBase<Funcionario> , IRepository<Funcionario>
    {
        public FuncionarioORM(LocadoraDeVeiculosDBContext db) : base(db)
        {
        }
    }
}
