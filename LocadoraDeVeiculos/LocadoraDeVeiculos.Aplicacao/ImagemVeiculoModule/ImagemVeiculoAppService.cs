using LocadoraDeVeiculos.Dominio.ImagemVeiculoModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Aplicacao.ImagemVeiculoModule
{
    public class ImagemVeiculoAppService
    {
        private readonly IImagemVeiculoRepository imagemVeiculoRepository;

        public string InserirNovaImagemVeiculo(ImagemVeiculo imagemVeiculo) {
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
        public void ExcluirImagemVeiculo(int id) { imagemVeiculoRepository.Excluir(id);}
        public ImagemVeiculo SelecionarImagemVeiculoPorId(int id) { return imagemVeiculoRepository.SelecionarPorId(id);}
        public List<ImagemVeiculo> SelecionarTodosImagemVeiculo() { return imagemVeiculoRepository.SelecionarTodos();}
        public List<ImagemVeiculo> SelecionarTodosImagemVeiculoDeUmVeiculo(int id) { return imagemVeiculoRepository.SelecionarPorIdDoVeiculo(id);}
        public void EditarListaImagemVeiculo(List<ImagemVeiculo> imagensVeiculo) { imagemVeiculoRepository.EditarLista(imagensVeiculo);}
        public void ExcluirImagemVeiculoPorIdDoVeiculo(int id) { imagemVeiculoRepository.ExcluirPorIdDoVeiculo(id);}


    }
}
