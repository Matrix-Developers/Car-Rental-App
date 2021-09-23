using LocadoraDeVeiculos.Dominio.ParceiroModule;

namespace LocadoraDeVeiculos.TestDataBuilders
{
    public class ParceiroDataBuilder
    {
        private readonly Parceiro parceiro;
        public ParceiroDataBuilder()
        {
            parceiro = new Parceiro();
        }

        public ParceiroDataBuilder ComNome(string nome)
        {
            parceiro.Nome = nome;
            return this;
        }

        public Parceiro Build()
        {
            return parceiro;
        }
    }
}