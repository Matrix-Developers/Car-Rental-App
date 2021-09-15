using LocadoraDeVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Dominio.ImagemVeiculoModule
{
    public interface IImagemVeiculoRepository : IRepository<ImagemVeiculo>
    {
        void EditarLista(List<ImagemVeiculo> registros);
        bool ExcluirPorIdDoVeiculo(int idVeiculo);
        List<ImagemVeiculo> SelecionarPorIdDoVeiculo(int id);
        List<ImagemVeiculo> SelecioanrTodasImagensDeUmVeiculo(int id);
    }
}
