using LocadoraDeVeiculos.Dominio.PessoaModule;
using System;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.ClienteModule
{
    public class Cliente : Pessoa
    {
        public string Cnh { get; }
        public DateTime? ValidadeCnh { get; }

        public Cliente(int id, string nome, string registroUnico, string endereco, string telefone, string email, string cnh, DateTime? validadeCnh, bool ehPessoaFisica)
        {
            this.id = id;
            Nome = nome;
            RegistroUnico = registroUnico;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            Cnh = cnh;
            ValidadeCnh = validadeCnh;
            EhPessoaFisica = ehPessoaFisica;
        }

        public override string Validar()
        {
            string resultadoValidação = "";
            if (EhPessoaFisica)
            {
                if (!ValidarCnh())
                    resultadoValidação += "CNH inválida\n";
                if (ValidadeCnh < DateTime.Now)
                    resultadoValidação += "CNH fora do prazo de validade\n";
            }
            if (base.ValidarPessoa() != "VALIDO")
                resultadoValidação += base.ValidarPessoa();
            if (resultadoValidação == "")
                resultadoValidação = "VALIDO";
            return resultadoValidação;
        }
        public bool ValidarCnh()
        {
            bool EhValida = false;
            var cnhSelecionada = this.Cnh;
            cnhSelecionada = this.Cnh.Replace(".", "").Replace("-", "").Replace(",", "");
            if (cnhSelecionada.Length < 11)
                return false;
            var firstChar = cnhSelecionada[0];
            if (cnhSelecionada.Length == 11 && cnhSelecionada != new string('1', 11))
            {
                var dsc = 0;
                var v = 0;
                for (int i = 0, j = 9; i < 9; i++, j--)
                    v += (Convert.ToInt32(cnhSelecionada[i].ToString()) * j);

                var vl1 = v % 11;
                if (vl1 >= 10)
                {
                    vl1 = 0;
                    dsc = 2;
                }

                v = 0;
                for (int i = 0, j = 1; i < 9; ++i, ++j)
                    v += (Convert.ToInt32(cnhSelecionada[i].ToString()) * j);

                var x = v % 11;
                var vl2 = (x >= 10) ? 0 : x - dsc;

                EhValida = vl1.ToString() + vl2.ToString() == cnhSelecionada.Substring(cnhSelecionada.Length - 2, 2);
            }
            return EhValida;
        }

        public override bool Equals(object obj)
        {
            return obj is Cliente cliente &&
                   id == cliente.id &&
                   Nome == cliente.Nome &&
                   RegistroUnico == cliente.RegistroUnico &&
                   Endereco == cliente.Endereco &&
                   Telefone == cliente.Telefone &&
                   Email == cliente.Email &&
                   EhPessoaFisica == cliente.EhPessoaFisica &&
                   Cnh == cliente.Cnh &&
                   ValidadeCnh == cliente.ValidadeCnh;
        }

        public override int GetHashCode()
        {
            int hashCode = -1382064342;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(RegistroUnico);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Endereco);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Telefone);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EhPessoaFisica.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Cnh);
            hashCode = hashCode * -1521134295 + ValidadeCnh.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"{id} {Nome} {RegistroUnico} {Endereco}";
        }
    }
}
