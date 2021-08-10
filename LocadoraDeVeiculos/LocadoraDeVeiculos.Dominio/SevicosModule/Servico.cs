namespace LocadoraDeVeiculos.Dominio.SevicosModule
{
    public class Servico
    {
        private string nome;
        private string tipo;
        private float valor;

        public Servico(string nome, string tipo, float valor)
        {
            this.nome = nome;
            this.tipo = tipo;
            this.valor = valor;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public float Valor { get => valor; set => valor = value; }

        public string Validar() 
        {
            string resultadoValidacao = "VALIDO";
            if (this.nome.Length <= 0)
                resultadoValidacao = "O nome não pode ser nulo\n";
            if (this.valor <= 0)
                resultadoValidacao += "O valor não pode ser nulo ou negativo";
            return resultadoValidacao;
        }
    }
}
