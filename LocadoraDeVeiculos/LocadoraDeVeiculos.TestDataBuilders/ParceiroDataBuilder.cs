using LocadoraDeVeiculos.Dominio.ParceiroModule;

namespace LocadoraDeVeiculos.TestDataBuilders
{
    public class ParceiroDataBuilder
    {
        private Parceiro parceiro;
        public ParceiroDataBuilder()
        {
            parceiro = new Parceiro();
        }

        public ParceiroDataBuilder ComNome(string nome)
        {
            parceiro.Nome = nome;
            return this;
        }
    }
}