using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.ImagemVeiculoModule
{
    public interface IImagemVeiculoRepository : IRepository<ImagemVeiculo, int>
    {
        void EditarLista(List<ImagemVeiculo> registros);
        bool ExcluirPoridDoVeiculo(int idVeiculo);
        List<ImagemVeiculo> SelecionarPorIdDoVeiculo(int id);
        List<ImagemVeiculo> SelecioanrTodasImagensDeUmVeiculo(int id);
    }
}
