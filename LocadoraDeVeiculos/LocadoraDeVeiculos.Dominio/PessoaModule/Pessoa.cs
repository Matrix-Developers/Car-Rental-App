using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.PessoaModule
{
    public class Pessoa
    {
        int id;
        string nome;
        string cpfCnpj;
        string endereco;
        string telefone;
        string email;
        bool ehPessoaFisica;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string CpfCnpj { get => cpfCnpj; set => cpfCnpj = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public bool EhPessoaFisica { get => ehPessoaFisica; set => ehPessoaFisica = value; }

        public Pessoa(int id, string nome, string cpfCnpj, string endereco, string telefone, string email, bool ehPessoaFisica)
        {
            this.id = id;
            this.nome = nome;
            this.cpfCnpj = cpfCnpj;
            this.endereco = endereco;
            this.telefone = telefone;
            this.email = email;
            this.ehPessoaFisica = ehPessoaFisica;
        }

        public string Validar()
        {
            string resultadoValidacao = "";
            int seZeroEhValido = 0;

            if (this.nome.Length <= 0)
            {
                resultadoValidacao = "O nome não pode ser nulo\n";
                seZeroEhValido++;
            }
            if (this.cpfCnpj.Length != 11 && this.cpfCnpj.Length != 14)
            {
                resultadoValidacao += "O CPF/CNPJ não está correto\n";
                seZeroEhValido++;
            }
            if (this.endereco.Length <= 0)
            {
                resultadoValidacao += "O endereço não pode ser nulo\n";
                seZeroEhValido++;
            }
            if (this.telefone.Length <= 0 && this.email.Length <= 0) // os dois nao
            {
                resultadoValidacao += "É obrigatório inserir Telefone ou E-mail\n";
                seZeroEhValido++;
            }
            if (this.telefone.Length != 0 && this.email.Length <= 0) // telefone-sim/ /email-nao
            {
                if (this.telefone.Length != 9)
                {
                    resultadoValidacao += "O telefone deve ter 9 dígitos\n";
                    seZeroEhValido++;
                }
            }
            if (this.email.Length != 0 && this.telefone.Length <= 0) // email-sim/ /telefone-nao
            {
                if (!(this.email.Contains('@')))
                {
                    resultadoValidacao += "O email está incorreto\n";
                    seZeroEhValido++;
                }
            }
            if (this.telefone.Length != 0 && this.email.Length != 0) // os dois sim
            {
                if (this.telefone.Length != 9)
                {
                    resultadoValidacao += "O telefone deve ter 9 dígitos\n";
                    seZeroEhValido++;
                }
                if (!(this.email.Contains('@')))
                {
                    resultadoValidacao += "O email está incorreto\n";
                    seZeroEhValido++;
                }
            }

            if (seZeroEhValido == 0)
                resultadoValidacao = "VALIDO";

            return resultadoValidacao;
        }

    }
}
