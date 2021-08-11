namespace LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule
{
    public class GrupoDeVeiculos
    {
        private string nome;
        private float taxaPlanoDiario;
        private float taxaKmControlado;
        private int quantidadeQuilometrosKmControlado;
        private float taxaKmLivre;

        public string Nome { get => nome; set => nome = value; }
        public float TaxaPlanoDiario { get => taxaPlanoDiario; set => taxaPlanoDiario = value; }
        public float TaxaKmControlado { get => taxaKmControlado; set => taxaKmControlado = value; }
        public int QuantidadeQuilometrosKmControlado { get => quantidadeQuilometrosKmControlado; set => quantidadeQuilometrosKmControlado = value; }
        public float TaxaKmLivre { get => taxaKmLivre; set => taxaKmLivre = value; }

        public GrupoDeVeiculos(string nome, float taxaPlanoDiario, float taxaKmControlado, int quantidadeQuilometrosKmControlado, float taxaKmLivre)
        {
            this.nome = nome;
            this.taxaPlanoDiario = taxaPlanoDiario;
            this.taxaKmControlado = taxaKmControlado;
            this.quantidadeQuilometrosKmControlado = quantidadeQuilometrosKmControlado;
            this.taxaKmLivre = taxaKmLivre;
        }

        public string Validar()
        {
            string resultadoValidacao = "";

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

            if (resultadoValidacao.Length == 0)
                resultadoValidacao = "VALIDO";

            return resultadoValidacao;
        }
    }
}
