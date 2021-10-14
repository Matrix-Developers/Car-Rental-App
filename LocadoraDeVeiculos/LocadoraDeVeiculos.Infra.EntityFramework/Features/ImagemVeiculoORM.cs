using LocadoraDeVeiculos.Dominio.ImagemVeiculoModule;
using LocadoraDeVeiculos.Infra.EntityFramework.Shared;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Features
{
    public class ImagemVeiculoORM : RepositoryBase<ImagemVeiculo>, IImagemVeiculoRepository
    {
        public ImagemVeiculoORM(LocadoraDeVeiculosDBContext db) : base(db)
        {
        }

        public void EditarLista(List<ImagemVeiculo> registros)
        {
            try
            {
                if (registros != null)
                {
                    if (registros.Count != 0)
                        ExcluirPorIdDoVeiculo(registros[0].IdVeiculo);
                    foreach (ImagemVeiculo imagem in registros)
                    {
                        InserirNovo(imagem);
                    }
                }
                db.SaveChanges();
            }
            catch (Exception)
            {
                return;
            }
        }

        public bool ExcluirPorIdDoVeiculo(int idVeiculo)
        {
            try
            {
                foreach (ImagemVeiculo imagem in SelecioanrTodasImagensDeUmVeiculo(idVeiculo))
                {
                    if (imagem.IdVeiculo == idVeiculo)
                        dbSet.Remove(imagem);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public List<ImagemVeiculo> SelecioanrTodasImagensDeUmVeiculo(int id)
        {
            try
            {
                return dbSet.ToList<ImagemVeiculo>();
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
