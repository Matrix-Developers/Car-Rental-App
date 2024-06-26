﻿using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.PessoaModule;
using System;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.ClienteModule
{
    public class Cliente : Pessoa
    {
        public string Cnh { get; set; }
        public DateTime? ValidadeCnh { get; set; }
        public List<Locacao> LocacoesCondutor { get; set; }
        public List<Locacao> LocacoesContratante { get; set; }

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

        public Cliente()
        {
        }

        public override string Validar()
        {
            string resultadoValidação = "";
            if (EhPessoaFisica)
            {
                if (!ValidarCnh())
                    resultadoValidação += "Invalid 'CNH'.\n";
                if (ValidadeCnh < DateTime.Now)
                    resultadoValidação += "CNH out of expiration date.\n";
            }
            if (base.ValidarPessoa() != "VALID")
                resultadoValidação += base.ValidarPessoa();
            if (resultadoValidação == "")
                resultadoValidação = "VALID";
            return resultadoValidação;
        }
        public bool ValidarCnh()
        {
            bool EhValida = false;
            var cnhSelecionada = this.Cnh.Replace(".", "").Replace("-", "").Replace(",", "");
            if (cnhSelecionada.Length < 11)
                return false;
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

        public override string ToString()
        {
            return $"{Nome}, {RegistroUnico}, {Telefone}, {Email}";
        }

        public override bool Equals(object obj)
        {
            return obj is Cliente cliente &&
                   Id == cliente.Id &&
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
            HashCode hash = new();
            hash.Add(Id);
            hash.Add(Nome);
            hash.Add(RegistroUnico);
            hash.Add(Endereco);
            hash.Add(Telefone);
            hash.Add(Email);
            hash.Add(EhPessoaFisica);
            hash.Add(Cnh);
            hash.Add(ValidadeCnh);
            return hash.ToHashCode();
        }
    }
}
