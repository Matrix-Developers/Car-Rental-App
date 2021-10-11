using LocadoraDeVeiculos.Dominio.Shared;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Shared
{
    public abstract class RepositoryBase<T> where T : EntidadeBase
    {
        protected readonly LocadoraDeVeiculosDBContext db;
        protected readonly DbSet<T> dbSet;

        protected RepositoryBase(LocadoraDeVeiculosDBContext db)
        {
            this.db = db;
            dbSet = db.Set<T>();
        }

        public bool InserirNovo(T registro)
        {
            try
            {
                dbSet.Add(registro);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Inserir um(a) novo(a) {Feature} / Camada: Repository / Usuário: IdUsuario / Sql: query / {StackTrace}", DateTime.Now, this.ToString(), ex);
                return false;
            }

            return true;
        }
        public bool Editar(int id, T registro)
        {
            try
            {
                T entidadeBaseParaEdicao = SelecionarPorId(id);
                entidadeBaseParaEdicao = registro;
                entidadeBaseParaEdicao.Id = id;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Editar  um(a) {Feature} / Camada: Repository / Id Processo: {IdProcesso} / Usuário: IdUsuario / Sql: query / {StackTrace}", DateTime.Now, this.ToString(), id, ex);
                return false;
            }
            return true;
        }
        public bool Excluir(int id)
        {
            try
            {
                T registro = SelecionarPorId(id);
                if (registro != null)
                {
                    dbSet.Remove(registro);
                    db.SaveChanges();
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Excluir um(a) {Feature} / Camada: Repository / Id Processo: {IdProcesso} / Usuário: IdUsuario / Sql: query / {StackTrace}", DateTime.Now, this.ToString(), id, ex);
                return false;
            }
            return true;
        }
        public T SelecionarPorId(int id)
        {
            try
            {
                return dbSet.FirstOrDefault(x => x.Id.Equals(id));
            }
            catch (Exception ex)
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Selecionar Por Id um(a) {Feature} / Camada: Repository / Id Processo: {IdProcesso} / Usuário: IdUsuario / Sql: query / {StackTrace}", DateTime.Now, this.ToString(), id, ex);
                return null;
            }
        }
        public List<T> SelecionarTodos()
        {
            try
            {
                return dbSet.ToList<T>();
            }
            catch (Exception ex)
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Selecionar Todos um(a) {Feature} / Camada: Repository / Usuário: IdUsuario / Sql: query / {StackTrace}", DateTime.Now, this.ToString(), ex);
                return null;
            }
        }
        public bool Existe(int id)
        {
            try
            {
                return dbSet.ToList().Exists(x => x.Id == id);
            }
            catch (Exception ex)
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Verificar se Existe o(a) {Feature} / Camada: Repository / Usuário: IdUsuario / Sql: query / {StackTrace}", DateTime.Now, this.ToString(), ex);
                return false;
            }
        }
    }
}
