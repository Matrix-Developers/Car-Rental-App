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
        private long tempo;
        public ClienteAppService(IRepository<Cliente> clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }

        public override bool InserirEntidade(Cliente cliente)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = clienteRepository.InserirNovo(cliente);
            tempo = DateTime.Now.Millisecond - tempo;

            if (resultado)
                Log.Information("{DataEHora} / Cliente {cliente} adicionado com sucesso", DateTime.Now, cliente);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Layer: {Layer} / Module: {Module} / Registro: {Id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Inserir", cliente, tempo);

            return resultado;
        }
        public override bool EditarEntidade(int id, Cliente cliente)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = clienteRepository.Editar(id, cliente);
            tempo = DateTime.Now.Millisecond - tempo;

            if (resultado)
                Log.Information("{DataEHora} / Cliente {cliente} editado com sucesso", DateTime.Now, cliente);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Layer: {Layer} / Module: {Module} / Registro: {Id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Editar", cliente, tempo);

            return resultado;
        }
        public override bool ExcluirEntidade(int id)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = clienteRepository.Excluir(id);
            tempo = DateTime.Now.Millisecond - tempo;

            if (resultado)
                Log.Information("{DataEHora} / Cliente {id} excluido com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Layer: {Layer} / Module: {Module} / Registro: {Id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Excluir", id, tempo);

            return resultado;
        }
        public override bool ExisteEntidade(int id)
        {
            return clienteRepository.Existe(id);
        }
        public override Cliente SelecionarEntidadePorId(int id)
        {
            tempo = DateTime.Now.Millisecond;
            Cliente cliente = clienteRepository.SelecionarPorId(id);
            tempo = DateTime.Now.Millisecond - tempo;

            if (cliente != null)
                Log.Information("{DataEHora} / Cliente {id} Selecionado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Layer: {Layer} / Module: {Module} / Registro: {Id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Selecionar por id", id, tempo);

            return cliente;
        }
        public override List<Cliente> SelecionarTodasEntidade()
        {
            tempo = DateTime.Now.Millisecond;
            List<Cliente> clientes = clienteRepository.SelecionarTodos();
            tempo = DateTime.Now.Millisecond - tempo;
            if (clientes != null)
                Log.Information("{DataEHora} / Cliente {id} Selecionado com sucesso", DateTime.Now, clientes.Count);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Layer: {Layer} / Module: {Module} / Registro: {Id} / Tempo total: {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Inserir", clientes.Count, tempo);
            return clientes;
        }
    }
}
