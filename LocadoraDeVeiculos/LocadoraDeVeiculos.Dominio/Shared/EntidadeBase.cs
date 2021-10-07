
namespace LocadoraDeVeiculos.Dominio.Shared
{
    public abstract class EntidadeBase<Tid>
    {
        public Tid id { get => id; set => id = value; }

        public abstract string Validar();
        public abstract override string ToString();
    }
}
