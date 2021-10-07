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
        private readonly IRepository<Veiculo,int> veiculoRepository;
        private readonly IImagemVeiculoRepository imagemVeiculoRepository;
        private readonly IReadOnlyRepository<Veiculo, int> readOnlyRepository;
        long tempo;

        public VeiculoAppService(IRepository<Veiculo,int> veiculoRepository, IImagemVeiculoRepository imagemVeiculoRepository, IReadOnlyRepository<Veiculo, int> readOnlyRepository)
        {
            this.veiculoRepository = veiculoRepository;
            this.imagemVeiculoRepository = imagemVeiculoRepository;
            this.readOnlyRepository = readOnlyRepository;
        }

        public override bool InserirEntidade(Veiculo veiculo)
        {
            GeradorLog.ConfigurarLog();
            tempo = DateTime.Now.Millisecond;
            bool resultado = veiculoRepository.InserirNovo(veiculo);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Veiculo {Veiculo} inserido com sucesso", DateTime.Now, veiculo);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: AppService / Módulo: Inserir / ID Registro: {id} {Tempo}ms", DateTime.Now, this.ToString(), veiculo.id,tempo);

            if (veiculo.imagens != null)
            {
                foreach (ImagemVeiculo imagemVeiculo in veiculo.imagens)
                {
                    imagemVeiculo.idVeiculo = veiculo.id;
                    imagemVeiculoRepository.InserirNovo(imagemVeiculo);
                }
            }

            return resultado;
        }
        public override bool EditarEntidade(int id, Veiculo veiculo)
        {
            GeradorLog.ConfigurarLog();
            tempo = DateTime.Now.Millisecond;
            bool resultado = veiculoRepository.Editar(id, veiculo);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Veiculo {Veiculo} editado com sucesso", DateTime.Now, veiculo);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / Registro: {id} {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Inserir", veiculo,tempo);

            if (veiculo.imagens != null)
                foreach (ImagemVeiculo imagem in veiculo.imagens)
                    imagem.idVeiculo = veiculo.id;
            imagemVeiculoRepository.EditarLista(veiculo.imagens);

            return resultado;
        }
        public override bool ExcluirEntidade(int id)
        {
            tempo = DateTime.Now.Millisecond;
            imagemVeiculoRepository.ExcluirPoridDoVeiculo(id);
            bool resultado = veiculoRepository.Excluir(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Veiculo {id} excluido com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {id} {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Excluir", id,tempo);
            return resultado;
        }
        public override bool ExisteEntidade(int id)
        {
            tempo = DateTime.Now.Millisecond;
            bool resultado = readOnlyRepository.Existe(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (resultado)
                Log.Information("{DataEHora} / Veiculo {Veiculo} encontrado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {id} {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Existe Entidade", id,tempo);
            return resultado;
        }
        public override Veiculo SelecionarEntidadePorId(int id)
        {
            tempo = DateTime.Now.Millisecond;
            Veiculo veiculo = readOnlyRepository.SelecionarPorId(id);
            veiculo.imagens = imagemVeiculoRepository.SelecioanrTodasImagensDeUmVeiculo(id);
            tempo = DateTime.Now.Millisecond - tempo;
            if (veiculo != null)
                Log.Information("{DataEHora} / Veiculo {id} selecionado com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} / ID Registro: {id} {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Selecionar Por id", id,tempo);
            return veiculo;
        }
        public override List<Veiculo> SelecionarTodasEntidade()
        {
            tempo = DateTime.Now.Millisecond;
            List<Veiculo> listVeiculos = readOnlyRepository.SelecionarTodos();
            tempo = DateTime.Now.Millisecond - tempo;
            if (listVeiculos != null)
            {
                foreach (Veiculo veiculo in listVeiculos)
                {
                    veiculo.imagens = imagemVeiculoRepository.SelecioanrTodasImagensDeUmVeiculo(veiculo.id);
                }
                Log.Information("{DataEHora} / {QtdSelecionados} Veiculos selecionados com sucesso", DateTime.Now, listVeiculos.Count);
            }
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: {Camada} / Módulo: {Modulo} {Tempo}ms", DateTime.Now, this.ToString(), "AppService", "Selecionar Todos",tempo);
           
            return listVeiculos;
        }
    }
}
