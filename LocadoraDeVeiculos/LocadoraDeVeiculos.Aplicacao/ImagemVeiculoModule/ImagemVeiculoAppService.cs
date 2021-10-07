using LocadoraDeVeiculos.Dominio.ImagemVeiculoModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Aplicacao.ImagemVeiculoModule
{
    public class ImagemVeiculoAppService        //nao está sendo usado. estamos utilizando diretamente o appService
    {
        private readonly IImagemVeiculoRepository imagemVeiculoRepository;
        private readonly IReadOnlyRepository<ImagemVeiculo, int> readOnlyRepository;

        public ImagemVeiculoAppService(IImagemVeiculoRepository imagemVeiculoRepository, IReadOnlyRepository<ImagemVeiculo, int> readOnlyRepository)
        {
            this.imagemVeiculoRepository = imagemVeiculoRepository;
            this.readOnlyRepository = readOnlyRepository;
        }

        public string InserirNovaImagemVeiculo(ImagemVeiculo imagemVeiculo)
        {
            string resultadoValidacao = imagemVeiculo.Validar();

            if (resultadoValidacao == "VALIDO")
                imagemVeiculoRepository.InserirNovo(imagemVeiculo);

            return resultadoValidacao;
        }
        public string EditarImagemVeiculo(ImagemVeiculo imagemVeiculo)
        {
            string resultadoValidacao = imagemVeiculo.Validar();

            if (resultadoValidacao == "VALIDO")
                imagemVeiculoRepository.InserirNovo(imagemVeiculo);

            return resultadoValidacao;
        }
        public void ExcluirImagemVeiculo(int id) { imagemVeiculoRepository.Excluir(id); }
        public ImagemVeiculo SelecionarImagemVeiculoPorid(int id) { return readOnlyRepository.SelecionarPorId(id); }
        public List<ImagemVeiculo> SelecionarTodosImagemVeiculo() { return readOnlyRepository.SelecionarTodos(); }
        public List<ImagemVeiculo> SelecionarTodosImagemVeiculoDeUmVeiculo(int id) { return imagemVeiculoRepository.SelecionarPorIdDoVeiculo(id); }
        public void EditarListaImagemVeiculo(List<ImagemVeiculo> imagensVeiculo) { imagemVeiculoRepository.EditarLista(imagensVeiculo); }
        public void ExcluirImagemVeiculoPoridDoVeiculo(int id) { imagemVeiculoRepository.ExcluirPoridDoVeiculo(id); }


    }
}
