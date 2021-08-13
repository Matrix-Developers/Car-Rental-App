using LocadoraDeVeiculos.Dominio.PessoaModule;
using System;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.FuncionarioModule
{
    public class Funcionario : Pessoa
    {
        public int MatriculaInterna { get; }
        public string UsuarioAcesso { get; }
        public DateTime DataAdmissao { get; }
        public string Cargo { get; }
        public double Salario { get; }

        public Funcionario(int id, string nome, string registroUnico, string endereco, string telefone, string email, int matriculaInterna, string usuarioAcesso, DateTime dataAdmissao, string cargo, double salario,bool ehPessoaFisica)
        {
            this.id = id;
            Nome = nome;
            RegistroUnico = registroUnico;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            EhPessoaFisica = true;
            MatriculaInterna = matriculaInterna;
            UsuarioAcesso = usuarioAcesso;
            DataAdmissao = dataAdmissao;
            Cargo = cargo;
            Salario = salario;
            EhPessoaFisica = ehPessoaFisica;
        }

        public override string Validar()
        {
            string resultadoValidação = "";
            if (UsuarioAcesso.Length == 0)
                resultadoValidação += "O usuário de acesso não pode estar vazio\n";
            if(MatriculaInterna <= 0)
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

        public override bool Equals(object obj)
        {
            return obj is Funcionario funcionario &&
                   id == funcionario.id &&
                   Nome == funcionario.Nome &&
                   RegistroUnico == funcionario.RegistroUnico &&
                   Endereco == funcionario.Endereco &&
                   Telefone == funcionario.Telefone &&
                   Email == funcionario.Email &&
                   EhPessoaFisica == funcionario.EhPessoaFisica &&
                   MatriculaInterna == funcionario.MatriculaInterna &&
                   UsuarioAcesso == funcionario.UsuarioAcesso &&
                   DataAdmissao == funcionario.DataAdmissao &&
                   Cargo == funcionario.Cargo &&
                   Salario == funcionario.Salario;
        }

        public override int GetHashCode()
        {
            int hashCode = 367286739;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(RegistroUnico);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Endereco);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Telefone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EhPessoaFisica.GetHashCode();
            hashCode = hashCode * -1521134295 + MatriculaInterna.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(UsuarioAcesso);
            hashCode = hashCode * -1521134295 + DataAdmissao.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Cargo);
            hashCode = hashCode * -1521134295 + Salario.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"Funcionario = [{id}, {Nome}, {RegistroUnico}, {Endereco}, {Telefone}, {Email}, {MatriculaInterna}, {UsuarioAcesso}, {DataAdmissao}, {Cargo}, {Salario}]";
        }
    }
}
