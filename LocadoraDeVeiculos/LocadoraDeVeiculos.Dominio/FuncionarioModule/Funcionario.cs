using LocadoraDeVeiculos.Dominio.PessoaModule;
using System;

namespace LocadoraDeVeiculos.Dominio.FuncionarioModule
{
    public class Funcionario : Pessoa
    {
        public int Matricula { get; }
        public string UsuarioAcesso { get; }
        public DateTime DataAdmissao { get; }
        public string Cargo { get; }
        public double Salario { get; }
        public Funcionario(int id, string nome, string registroUnico, string endereco, string telefone, string email, int matricula, string usuarioAcesso, DateTime dataAdmissao, string cargo, double salario)
        {
            Id = id;
            Nome = nome;
            RegistroUnico = registroUnico;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            EhPessoaFisica = true;
            Matricula = matricula;
            UsuarioAcesso = usuarioAcesso;
            DataAdmissao = dataAdmissao;
            Cargo = cargo;
            Salario = salario;
        }

        public string Validar()
        {
            string resultadoValidação = "";
            if (UsuarioAcesso.Length == 0)
                resultadoValidação += "O usuário de acesso não pode estar vazio\n";
            if(Matricula <= 0)
                resultadoValidação += "Matricula inválida\n";
            if (Salario <= 0)
                resultadoValidação += "O salário deve ser maior que R$ 0,00\n";
            if(Cargo.Length == 0)
                resultadoValidação += "O funcionário deve possuir um cargo\n";
            if (DataAdmissao > DateTime.Now.AddMonths(2))
                resultadoValidação += "Data de admissão inválida\n";
            if (base.ValidarPessoa() != "VALIDO")
                resultadoValidação += base.ValidarPessoa();
            if (resultadoValidação == "")
                resultadoValidação += "VALIDO";
            return resultadoValidação;
        }
    }
}
