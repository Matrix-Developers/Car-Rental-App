namespace LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule
{
    public class GrupoDeVeiculos
    {
        public string nome;
        public float taxaPlanoDiario;
        public float taxaKmControlado;
        public int quantidadeQuilometrosKmControlado;
        public float taxaKmLivre;

        public string Validar()
        {
            string resultadoValidacao = "VALIDO";

            if (this.nome.Length <= 0)
                resultadoValidacao  = "O nome não pode ser nulo\n";

            if (this.taxaKmControlado <= 0f)
                resultadoValidacao += "A taxa do Quilometro Controlado não pode ser nula nem negativa\n";

            if (this.taxaPlanoDiario <=0f)
                resultadoValidacao += "A taxa do Plano Diário não pode ser nula nem negativa\n";

            if (this.taxaKmLivre <= 0f)
                resultadoValidacao += "A taxa do Quilometro Livre não pode ser nula nem negativa\n";

            if (this.quantidadeQuilometrosKmControlado <= 0)
                resultadoValidacao += "A quantidade de quilômetros não pode ser nulo nem negativo";

            return resultadoValidacao;
        }
    }
}
