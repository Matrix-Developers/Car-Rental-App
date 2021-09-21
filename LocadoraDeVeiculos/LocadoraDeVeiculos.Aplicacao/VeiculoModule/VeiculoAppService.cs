using LocadoraDeVeiculos.Dominio.ImagemVeiculoModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Aplicacao.VeiculoModule
{
    public class VeiculoAppService
    {
        private readonly IRepository<Veiculo> veiculoRepository;
        private readonly IImagemVeiculoRepository imagemVeiculoRepository;

        public VeiculoAppService(IRepository<Veiculo> veiculoRepository)
        {
            this.veiculoRepository = veiculoRepository;
        }

        public string InserirNovoVeiculo(Veiculo veiculo){
            string resultadoValidacao = veiculo.Validar();

            if (resultadoValidacao == "VALIDO")
                veiculoRepository.InserirNovo(veiculo);

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
        public string EditarVeiculo(int id, Veiculo veiculo)
        {
            string resultadoValidacao = veiculo.Validar();
            veiculo.Id = id;
            if (resultadoValidacao == "VALIDO")
            {
                veiculoRepository.Editar(id, veiculo);

                if (veiculo.imagens != null)
                    foreach (ImagemVeiculo imagem in veiculo.imagens)
                        imagem.IdVeiculo = veiculo.Id;
                imagemVeiculoRepository.EditarLista(veiculo.imagens);
            }

            return resultadoValidacao;
        }
        public bool ExcluirVeiculo(int id) {
            imagemVeiculoRepository.ExcluirPorIdDoVeiculo(id);
            return veiculoRepository.Excluir(id);
        }
        public bool ExisteVeiculo(int id) { return veiculoRepository.Existe(id);}
        public Veiculo SelecionarVeiculoPorId(int id) { 
            Veiculo veiculo = veiculoRepository.SelecionarPorId(id);
            veiculo.imagens = imagemVeiculoRepository.SelecioanrTodasImagensDeUmVeiculo(id);
            return veiculo;
        }
        public List<Veiculo> SelecionarTodosVeiculo() {
            List<Veiculo> veiculos = veiculoRepository.SelecionarTodos();
            foreach (Veiculo veiculo in veiculos)
            {
                veiculo.imagens = imagemVeiculoRepository.SelecioanrTodasImagensDeUmVeiculo(veiculo.Id);
            }
            return veiculos;
        }
    }
}
