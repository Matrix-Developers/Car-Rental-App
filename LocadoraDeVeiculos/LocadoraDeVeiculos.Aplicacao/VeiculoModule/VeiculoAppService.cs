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

        public override string InserirEntidade(Veiculo veiculo)
        {
            string resultadoValidacao = veiculo.Validar();

            if (resultadoValidacao == "VALIDO")
            {
                GeradorLog.ConfigurarLog();
                bool resultado = veiculoRepository.InserirNovo(veiculo);
                if (resultado)
                    Log.Information("{DataEHora} / Veiculo {Id} inserido com sucesso", DateTime.Now, veiculo.Id);
                else
                    Log.Error("{DataEHora} / Feature: {Feature} / Camada: AppService / Módulo: Inserir / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), veiculo.Id);
            }

            if (veiculo.imagens != null)
            {
                foreach (ImagemVeiculo imagemVeiculo in veiculo.imagens)
                {
                    imagemVeiculo.IdVeiculo = veiculo.Id;
                    imagemVeiculoRepository.InserirNovo(imagemVeiculo);
                }
            }

            return resultadoValidacao;
        }
        public override string EditarEntidade(int id, Veiculo veiculo)
        {
            string resultadoValidacao = veiculo.Validar();
            if (resultadoValidacao == "VALIDO")
            {
                GeradorLog.ConfigurarLog();
                bool resultado = veiculoRepository.Editar(id, veiculo);
                if (resultado)
                    Log.Information("{DataEHora} / Veiculo {Id} editado com sucesso", DateTime.Now, id);
                else
                    Log.Error("{DataEHora} / Feature: {Feature} / Camada: AppService / Módulo: Editar / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), id);
            }

            return resultadoValidacao;
        }
        public override bool ExcluirEntidade(int id)
        {
            imagemVeiculoRepository.ExcluirPorIdDoVeiculo(id);
            GeradorLog.ConfigurarLog();
            bool resultado = veiculoRepository.Excluir(id);
            if (resultado)
                Log.Information("{DataEHora} / Veiculo {Id} excluido com sucesso", DateTime.Now, id);
            else
                Log.Error("{DataEHora} / Feature: {Feature} / Camada: AppService / Módulo: Excluir / ID Registro: {Id} / Tempo total: ?????", DateTime.Now, this.ToString(), id);
            return resultado;
        }
        public override bool ExisteEntidade(int id)
        {
            return veiculoRepository.Existe(id);
        }
        public override Veiculo SelecionarEntidadePorId(int id)
        {
            Veiculo veiculo = veiculoRepository.SelecionarPorId(id);
            veiculo.imagens = imagemVeiculoRepository.SelecioanrTodasImagensDeUmVeiculo(id);
            return veiculo;
        }
        public override List<Veiculo> SelecionarTodasEntidade()
        {
            List<Veiculo> veiculos = veiculoRepository.SelecionarTodos();
            foreach (Veiculo veiculo in veiculos)
            {
                veiculo.imagens = imagemVeiculoRepository.SelecioanrTodasImagensDeUmVeiculo(veiculo.Id);
            }
            return veiculos;
        }
    }
}
