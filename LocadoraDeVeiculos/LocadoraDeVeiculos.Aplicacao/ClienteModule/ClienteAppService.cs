using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Aplicacao.ClienteModule
{
    public class ClienteAppService
    {
        private IRepository<Cliente> clienteRepository;

        public ClienteAppService(IRepository<Cliente> clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        public string InserirNovoCliente(Cliente cliente){
            string resultadoValidacao = cliente.Validar();

            if (resultadoValidacao == "VALIDO"){
                clienteRepository.InserirNovo(cliente);
            }

            return resultadoValidacao;
        }
        public string EditarCliente(int id, Cliente cliente){
            string resultadoValidacao = cliente.Validar();

            if (resultadoValidacao == "VALIDO"){
                clienteRepository.Editar(id, cliente);
            }

            return resultadoValidacao;
        }
        public void ExcluirCliente(int id){clienteRepository.Excluir(id);}
        public bool ExisteCliente(int id){ return clienteRepository.Existe(id);}
        public Cliente SelecionarClientePorId(int id){ return clienteRepository.SelecionarPorId(id);}
        public List<Cliente> SelecionarTodosCliente(){ return clienteRepository.SelecionarTodos();}

    }
}
