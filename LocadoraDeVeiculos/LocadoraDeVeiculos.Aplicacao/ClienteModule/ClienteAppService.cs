using LocadoraDeVeiculos.Aplicacao.Shared;
using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.Shared;
using Serilog;
using System;
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

            if (resultado)
                Log.Information("{DataEHora} / Cliente {cliente} adicionado com sucesso", DateTime.Now, cliente);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Inserir", cliente);

            return resultado;
        }
        public override bool EditarEntidade(int id, Cliente cliente)
        {
            bool resultado = clienteRepository.Editar(id, cliente);
            if (resultado)
                Log.Information("{DataEHora} / Cliente {cliente} editado com sucesso", DateTime.Now, cliente);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Editar", cliente);

            return resultado;
        }
        public override bool ExcluirEntidade(int id)
        {
            bool resultado = clienteRepository.Excluir(id);

            if (resultado)
                Log.Information("{DataEHora} / Cliente {id} excluido com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Excluir", id);

            return resultado;
        }
        public override bool ExisteEntidade(int id)
        {
            return clienteRepository.Existe(id);
        }
        public override Cliente SelecionarEntidadePorId(int id)
        {
            Cliente cliente = clienteRepository.SelecionarPorId(id);

            if (cliente != null)
                Log.Information("{DataEHora} / Cliente {id} Selecionado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Selecionar por id", id);

            return cliente;
        }
        public override List<Cliente> SelecionarTodasEntidade()
        {
            List<Cliente> clientes = clienteRepository.SelecionarTodos();
            if(clientes != null)
                Log.Information("{DataEHora} / Cliente {id} Selecionado com sucesso", DateTime.Now, clientes.Count);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Módulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Inserir", clientes.Count);
            return clientes;
        }
    }
}
