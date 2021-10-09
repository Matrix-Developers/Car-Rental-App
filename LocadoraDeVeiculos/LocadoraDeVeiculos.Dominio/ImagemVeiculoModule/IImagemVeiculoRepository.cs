using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.ImagemVeiculoModule
{
    public interface IImagemVeiculoRepository : IRepository<ImagemVeiculo>
    {
        void EditarLista(List<ImagemVeiculo> registros);
        bool ExcluirPorIdDoVeiculo(int idVeiculo);
        List<ImagemVeiculo> SelecioanrTodasImagensDeUmVeiculo(int id);
    }
}
