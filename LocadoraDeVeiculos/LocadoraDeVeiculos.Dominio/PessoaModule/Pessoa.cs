using LocadoraDeVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            bool resultadoValidacaoRegistroUnico = false;
            if (EhPessoaFisica)
                resultadoValidacaoRegistroUnico = ValidarCpf(RegistroUnico);
            else
                resultadoValidacaoRegistroUnico = ValidarCnpj(RegistroUnico);

            if (this.Nome.Length == 0)
                resultadoValidacao = "O nome não pode ser nulo\n";
            if (this.Endereco.Length <= 0)
                resultadoValidacao += "O endereço não pode ser nulo\n";
            if (this.Telefone.Length == 0 && this.Email.Length == 0)
                resultadoValidacao += "É obrigatório inserir Telefone ou E-mail\n";
            else
            {
                if (this.Telefone.Length > 0 && this.Telefone.Length < 9)
                    resultadoValidacao += "O telefone deve ter no mínimo 9 dígitos\n";
                if (this.Email.Length > 0 && !(this.Email.Contains('@')))
                    resultadoValidacao += "O email está incorreto\n";
            }

            if (!resultadoValidacaoRegistroUnico)
            {
                if (EhPessoaFisica)
                    resultadoValidacao += "O CPF não é válido\n";
                else
                    resultadoValidacao += "O CNPJ não é válido\n";
            }
            if (resultadoValidacao == "")
                resultadoValidacao = "VALIDO";

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
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
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
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }
    }
}
