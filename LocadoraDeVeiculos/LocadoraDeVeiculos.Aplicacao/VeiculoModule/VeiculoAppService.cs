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

        public string InserirNovoVeiculo(Veiculo veiculo){
            string resultadoValidacao = veiculo.Validar();

            if (resultadoValidacao == "VALIDO")
                veiculoRepository.InserirNovo(veiculo);

            return resultadoValidacao;
        }
        public string EditarVeiculo(int id, Veiculo veiculo)
        {
            string resultadoValidacao = veiculo.Validar();

            if (resultadoValidacao == "VALIDO")
                veiculoRepository.Editar(id ,veiculo);

            return resultadoValidacao;
        }
        public bool ExcluirVeiculo(int id) { return veiculoRepository.Excluir(id);}
        public bool ExisteVeiculo(int id) { return veiculoRepository.Existe(id);}
        public Veiculo SelecionarVeiculoPorId(int id) { return veiculoRepository.SelecionarPorId(id);}
        public List<Veiculo> SelecionarTodosVeiculo() { return veiculoRepository.SelecionarTodos();}
    }
}
