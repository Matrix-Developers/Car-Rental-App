using LocadoraDeVeiculos.Aplicacao.Shared;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Aplicacao.ClienteModule
{
    public class ClienteAppService : AppServiceBase<Cliente>
    {
        private readonly IRepository<Cliente> clienteRepository;

        public ClienteAppService(IRepository<Cliente> clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        public override bool InserirEntidade(Cliente cliente)
        {
           bool resultado = clienteRepository.InserirNovo(cliente);

            return resultado;
        }
        public override bool EditarEntidade(int id, Cliente cliente)
        {
            bool resultado = clienteRepository.Editar(id, cliente);

            return resultado;
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
