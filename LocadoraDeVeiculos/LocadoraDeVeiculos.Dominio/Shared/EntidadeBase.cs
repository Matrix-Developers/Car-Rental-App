

namespace LocadoraDeVeiculos.Dominio.Shared
{
    public abstract class EntidadeBase
    {
        protected int id;

        public int Id { get => id; set => id = value; }

        public abstract string Validar();
        public abstract override string ToString();
        public abstract override bool Equals(object obj);
        public abstract override int GetHashCode();
    }
}
