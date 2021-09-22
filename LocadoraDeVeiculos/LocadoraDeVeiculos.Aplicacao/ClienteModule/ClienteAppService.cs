using LocadoraDeVeiculos.Aplicacao.Shared;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Aplicacao.ClienteModule
{
    public class ClienteAppService : AppServiceBase<Cliente>
    {
        private IRepository<Cliente> clienteRepository;

        public ClienteAppService(IRepository<Cliente> clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        public override string InserirEntidade(Cliente cliente)
        {
            string resultadoValidacao = cliente.Validar();

            if (resultadoValidacao == "VALIDO")
            {
                clienteRepository.InserirNovo(cliente);
            }

            return resultadoValidacao;
        }
        public override string EditarEntidade(int id, Cliente cliente)
        {
            string resultadoValidacao = cliente.Validar();

            if (resultadoValidacao == "VALIDO")
            {
                clienteRepository.Editar(id, cliente);
            }

            return resultadoValidacao;
        }
        public override bool ExcluirEntidade(int id)
        {
            return clienteRepository.Excluir(id);
        }
        public override bool ExisteEntidade(int id)
        {
            return clienteRepository.Existe(id);
        }
        public override Cliente SelecionarEntidadePorId(int id)
        {
            return clienteRepository.SelecionarPorId(id);
        }
        public override List<Cliente> SelecionarTodasEntidade()
        {
            return clienteRepository.SelecionarTodos();
        }
    }
}
