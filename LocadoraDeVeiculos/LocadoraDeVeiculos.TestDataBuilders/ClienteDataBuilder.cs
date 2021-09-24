using LocadoraDeVeiculos.Dominio.ClienteModule;
using System;

namespace LocadoraDeVeiculos.TestDataBuilders
{
    public class ClienteDataBuilder
    {
        private readonly Cliente cliente;

        public ClienteDataBuilder()
        {
            cliente = new Cliente();
        }

        public ClienteDataBuilder ComNome(string nome)
        {
            cliente.Nome = nome;
            return this;
        }
        public ClienteDataBuilder ComRegistroUnico(string registroUnico)
        {
            cliente.RegistroUnico = registroUnico;
            return this;
        }
        public ClienteDataBuilder ComEndereco(string endereco)
        {
            cliente.Endereco = endereco;
            return this;
        }
        public ClienteDataBuilder ComTelefone(string telefone)
        {
            cliente.Telefone = telefone;
            return this;
        }
        public ClienteDataBuilder ComEmail(string email)
        {
            cliente.Email = email;
            return this;
        }
        public ClienteDataBuilder ComCnh(string cnh)
        {
            cliente.Cnh = cnh;
            return this;
        }
        public ClienteDataBuilder ComValidadeCnh(DateTime? validadeCnh)
        {
            cliente.ValidadeCnh = validadeCnh;
            return this;
        }

        public ClienteDataBuilder ComEhPessoaFisica(bool ehPessoaFisica)
        {
            cliente.EhPessoaFisica = ehPessoaFisica;
            return this;
        }

        public Cliente Build()
        {
            return cliente;
        }
    }
}
