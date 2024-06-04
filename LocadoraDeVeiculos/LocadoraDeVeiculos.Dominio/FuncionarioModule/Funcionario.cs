using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.PessoaModule;
using System;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.FuncionarioModule
{
    public class Funcionario : Pessoa
    {
        public int MatriculaInterna { get; set; }
        public string UsuarioAcesso { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public string Senha { get; set; }
        public List<Locacao> Locacoes { get; set; }

        public Funcionario(int id, string nome, string registroUnico, string endereco, string telefone, string email, int matriculaInterna, string usuarioAcesso, string senha, DateTime dataAdmissao, string cargo, double salario, bool ehPessoaFisica)
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
            Senha = senha;
            DataAdmissao = dataAdmissao;
            Cargo = cargo;
            Salario = salario;
            EhPessoaFisica = ehPessoaFisica;
        }

        public Funcionario(string usuarioAcesso, string cargo)
        {
            UsuarioAcesso = usuarioAcesso;
            Cargo = cargo;
        }

        public Funcionario()
        {
        }

        public override string Validar()
        {
            string resultadoValidação = "";
            if (UsuarioAcesso == "admin")
                return "VALIDO";
            if (UsuarioAcesso.Length == 0)
                resultadoValidação += "O usuário de acesso não pode estar vazio\n";
            if (MatriculaInterna <= 0)
                resultadoValidação += "Matricula inválida\n";
            if (Salario <= 0)
                resultadoValidação += "O salário deve ser maior que R$ 0,00\n";
            if (Cargo.Length == 0)
                resultadoValidação += "O funcionário deve possuir um cargo\n";
            if (DataAdmissao > DateTime.Now.AddMonths(2))
                resultadoValidação += "Data de admissão inválida\n";
            if (Senha.Length <= 3)
                resultadoValidação += "A senha não pode ser menor que três caracteres\n";
            if (base.ValidarPessoa() != "VALIDO")
                resultadoValidação += base.ValidarPessoa();
            if (resultadoValidação == "")
                resultadoValidação += "VALIDO";
            return resultadoValidação;
        }

        public override string ToString()
        {
            return $"{Nome}, {MatriculaInterna}, {Telefone}, {Cargo}";
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
                   Salario == funcionario.Salario &&
                   Senha == funcionario.Senha;
        }

        public override int GetHashCode()
        {
            int hashCode = 497940720;
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
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Senha);
            return hashCode;
        }
    }
}
