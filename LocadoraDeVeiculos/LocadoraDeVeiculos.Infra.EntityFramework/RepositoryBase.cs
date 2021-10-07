using LocadoraDeVeiculos.Dominio.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LocadoraDeVeiculos.Infra.EntityFramework
{
    public class RepositoryBase<TEntity, TKey> : IReadOnlyRepository<TEntity, TKey>, IRepository<TEntity, TKey>
        where TEntity : EntidadeBase<TKey>
    {
        protected readonly LocadoraDeVeiculosDBContext db;
        protected readonly DbSet<TEntity> dbSet;
        public RepositoryBase(LocadoraDeVeiculosDBContext dBContext)
        {
            this.db = dBContext;
            dbSet = db.Set<TEntity>();
        }
        public bool InserirNovo(TEntity registro)
        {
            try
            {
                dbSet.Add(registro);

                db.SaveChanges();
            }
            catch(Exception ex)
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Inserir um(a) novo(a) {Feature} / Camada: Repository / Usuário: idUsuario / {StackTrace}", DateTime.Now, this.ToString(), ex);
                return false;
            }
            return true;
        }
        public bool Editar(int id, TEntity registro)
        {
            EntityEntry dbEntityEntry = db.Entry(registro);

            try
            {
                
            }
            catch (Exception ex)
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Editar  um(a) {Feature} / Camada: Repository / id Processo: {idProcesso} / Usuário: idUsuario / Sql: {query} / {StackTrace}", DateTime.Now, this.ToString(), id, ex);
                return false;
            }
            return true;
        }

        public bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public bool Existe(TKey id)
        {
            throw new NotImplementedException();
        }        

        public TEntity SelecionarPorId(TKey id)
        {
            return dbSet.SingleOrDefault(x => x.id.Equals(id));
        }

        public List<TEntity> SelecionarTodos()
        {
            return dbSet.ToList<TEntity>();
        }
    }
}
