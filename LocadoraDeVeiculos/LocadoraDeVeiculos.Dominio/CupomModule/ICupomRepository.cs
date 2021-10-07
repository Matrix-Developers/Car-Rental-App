using LocadoraDeVeiculos.Dominio.Shared;

namespace LocadoraDeVeiculos.Dominio.CupomModule
{
    public interface ICupomRepository : IRepository<Cupom, int>, IReadOnlyRepository<Cupom, int>
    {
        public Cupom SelecionarPorCodigo(string codigo);
        public void AtualizarQtdUtilizada(int id, int qtdUtilizada);
        public bool ExisteCodigo(string codigo);
    }
}
