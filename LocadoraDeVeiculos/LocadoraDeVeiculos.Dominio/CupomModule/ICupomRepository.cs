using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.CupomModule
{
    public interface ICupomRepository : IRepository<Cupom>
    {
        public Cupom SelecionarPorCodigo(string codigo);
        public void AtualizarQtdUtilizada(int id, int qtdUtilizada);
    }
}
