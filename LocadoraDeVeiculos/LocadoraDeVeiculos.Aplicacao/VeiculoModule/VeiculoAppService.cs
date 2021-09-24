using LocadoraDeVeiculos.Aplicacao.Shared;
using LocadoraDeVeiculos.Dominio.ImagemVeiculoModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
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
            bool resultadoValidacao = veiculoRepository.InserirNovo(veiculo);

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
        public override bool EditarEntidade(int id, Veiculo veiculo)
        {
            bool resultadoValidacao = veiculoRepository.Editar(id, veiculo);

            if (veiculo.imagens != null)
                foreach (ImagemVeiculo imagem in veiculo.imagens)
                    imagem.IdVeiculo = veiculo.Id;
            imagemVeiculoRepository.EditarLista(veiculo.imagens);

            return resultadoValidacao;
        }
        public override bool ExcluirEntidade(int id)
        {
            imagemVeiculoRepository.ExcluirPorIdDoVeiculo(id);
            return veiculoRepository.Excluir(id);
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
