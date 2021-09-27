using LocadoraDeVeiculos.Aplicacao.Shared;
using LocadoraDeVeiculos.Dominio.ImagemVeiculoModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using LocadoraDeVeiculos.Infra.Logs;
using Serilog;
using System;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Aplicacao.VeiculoModule
{
    public class VeiculoAppService : AppServiceBase<Veiculo>
    {
        private readonly IRepository<Veiculo> veiculoRepository;
        private readonly IImagemVeiculoRepository imagemVeiculoRepository;

        public VeiculoAppService(IRepository<Veiculo> veiculoRepository, IImagemVeiculoRepository imagemVeiculoRepository)
        {
            this.veiculoRepository = veiculoRepository;
            this.imagemVeiculoRepository = imagemVeiculoRepository;
        }

        public override bool InserirEntidade(Veiculo veiculo)
        {
            GeradorLog.ConfigurarLog();
            bool resultado = veiculoRepository.InserirNovo(veiculo);
            if (resultado)
                Log.Information("{DataEHora} / Veiculo {Veiculo} inserido com sucesso", DateTime.Now, veiculo);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: AppService / Módulo: Inserir / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), veiculo.Id);

            if (veiculo.imagens != null)
            {
                foreach (ImagemVeiculo imagemVeiculo in veiculo.imagens)
                {
                    imagemVeiculo.IdVeiculo = veiculo.Id;
                    imagemVeiculoRepository.InserirNovo(imagemVeiculo);
                }
            }

            return resultado;
        }
        public override bool EditarEntidade(int id, Veiculo veiculo)
        {
            GeradorLog.ConfigurarLog();
            bool resultado = veiculoRepository.Editar(id, veiculo);
            if (resultado)
                Log.Information("{DataEHora} / Veiculo {Veiculo} editado com sucesso", DateTime.Now, veiculo);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Inserir", veiculo);

            if (veiculo.imagens != null)
                foreach (ImagemVeiculo imagem in veiculo.imagens)
                    imagem.IdVeiculo = veiculo.Id;
            imagemVeiculoRepository.EditarLista(veiculo.imagens);

            return resultado;
        }
        public override bool ExcluirEntidade(int id)
        {
            imagemVeiculoRepository.ExcluirPorIdDoVeiculo(id);
            bool resultado = veiculoRepository.Excluir(id);
            if (resultado)
                Log.Information("{DataEHora} / Veiculo {Id} excluido com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Excluir", id);
            return resultado;
        }
        public override bool ExisteEntidade(int id)
        {
            bool resultado = veiculoRepository.Existe(id);
            if (resultado)
                Log.Information("{DataEHora} / Veiculo {Veiculo} encontrado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Existe Entidade", id);
            return resultado;
        }
        public override Veiculo SelecionarEntidadePorId(int id)
        {
            Veiculo veiculo = veiculoRepository.SelecionarPorId(id);
            veiculo.imagens = imagemVeiculoRepository.SelecioanrTodasImagensDeUmVeiculo(id);
            if (veiculo != null)
                Log.Information("{DataEHora} / Veiculo {Id} selecionado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Selecionar Por Id", id);
            return veiculo;
        }
        public override List<Veiculo> SelecionarTodasEntidade()
        {
            List<Veiculo> listVeiculos = veiculoRepository.SelecionarTodos();
            if (listVeiculos != null)
            {
                foreach (Veiculo veiculo in listVeiculos)
                {
                    veiculo.imagens = imagemVeiculoRepository.SelecioanrTodasImagensDeUmVeiculo(veiculo.Id);
                }
                Log.Information("{DataEHora} / {QtdSelecionados} Veiculos selecionados com sucesso", DateTime.Now, listVeiculos.Count);
            }
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Tempo total: ?????", DateTime.Now, this.ToString(), "AppService", "Selecionar Todos");
           
            return listVeiculos;
        }
    }
}
