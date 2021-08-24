using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Controladores.VeiculoModule;
using LocadoraDeVeiculos.Dominio.ImagemVeiculoModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;

namespace LocadoraDeVeiculos.Controladores.ImagemVeiculoModule
{
    public class ControladorImagemVeiculo : Controlador<ImagemVeiculo>
    {
        #region Queries

        #endregion
        public override string Editar(int id, ImagemVeiculo registro)
        {
            throw new NotImplementedException();
        }

        public override bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Existe(int id)
        {
            throw new NotImplementedException();
        }

        public override string InserirNovo(ImagemVeiculo registro)
        {
            throw new NotImplementedException();
        }

        public override ImagemVeiculo SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public override List<ImagemVeiculo> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
