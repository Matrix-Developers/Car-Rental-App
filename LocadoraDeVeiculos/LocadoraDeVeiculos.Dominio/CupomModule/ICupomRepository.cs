using LocadoraDeVeiculos.Dominio.Shared;

namespace LocadoraDeVeiculos.Dominio.CupomModule
{
    public interface ICupomRepository : IRepository<Cupom>
    {
        public Cupom SelecionarPorCodigo(string codigo);
        public void AtualizarQtdUtilizada(int id, int qtdUtilizada);
        public bool ExisteCodigo(string codigo);
    }
}
