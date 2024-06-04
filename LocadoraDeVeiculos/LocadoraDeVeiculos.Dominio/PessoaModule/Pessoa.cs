using LocadoraDeVeiculos.Dominio.Shared;

namespace LocadoraDeVeiculos.Dominio.PessoaModule
{
    public abstract class Pessoa : EntidadeBase
    {
        public string Nome { get; set; }
        public string RegistroUnico { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool EhPessoaFisica { get; set; }

        public virtual string ValidarPessoa()
        {
            string resultadoValidacao = "";
            bool resultadoValidacaoRegistroUnico;
            if (EhPessoaFisica)
                resultadoValidacaoRegistroUnico = ValidarCpf(RegistroUnico);
            else
                resultadoValidacaoRegistroUnico = ValidarCnpj(RegistroUnico);

            if (this.Nome.Length == 0)
                resultadoValidacao = "The name field cannot be null.\n";
            if (this.Endereco.Length <= 0)
                resultadoValidacao += "The address field cannot be null.\n";
            if (this.Email.Length == 0 || (!this.Email.Contains('@')))
                resultadoValidacao += "The email field must be valid and not null.\n";
            if (!resultadoValidacaoRegistroUnico)
            {
                if (EhPessoaFisica)
                    resultadoValidacao += "The CPF field is not valid.\n";
                else
                    resultadoValidacao += "The CNPJ field is not valid.\n";
            }
            if (resultadoValidacao == "")
                resultadoValidacao = "VALID";

            return resultadoValidacao;
        }

        private static bool ValidarCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "").Replace(",", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf += digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito += resto.ToString();
            return cpf.EndsWith(digito);
        }

        private static bool ValidarCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj += digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito += resto.ToString();
            return cnpj.EndsWith(digito);
        }
    }
}
