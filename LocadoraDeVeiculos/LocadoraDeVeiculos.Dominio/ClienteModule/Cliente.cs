using LocadoraDeVeiculos.Dominio.PessoaModule;
using System;

namespace LocadoraDeVeiculos.Dominio.ClienteModule
{
    public class Cliente : Pessoa
    {
        public string Cnh { get; }
        public DateTime ValidadeCnh { get; }

        public Cliente(int id, string nome, string registroUnico, string endereco, string telefone, string email, string cnh, DateTime validadeCnh, bool ehPessoaFisica)
        {
            Id = id;
            Nome = nome;
            RegistroUnico = registroUnico;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            Cnh = cnh;
            ValidadeCnh = validadeCnh;
            EhPessoaFisica = ehPessoaFisica;
        }

        public string Validar()
        {
            string resultadoValidação = "";
            if (!ValidarCnh())
                resultadoValidação += "CNH inválida\n";
            if (ValidadeCnh < DateTime.Now)
                resultadoValidação += "CNH fora do prazo de validade\n";
            resultadoValidação += base.ValidarPessoa();
            return resultadoValidação;
        }
        public bool ValidarCnh()
        {
            bool EhValida = false;
            var cnhSelecionada = this.Cnh;
            cnhSelecionada = this.Cnh.Replace(".", "").Replace("-", "");
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
    }
}
