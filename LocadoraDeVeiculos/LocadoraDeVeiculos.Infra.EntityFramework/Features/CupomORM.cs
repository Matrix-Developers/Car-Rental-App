using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.Infra.EntityFramework.Shared;
using Serilog;
using System;
using System.Linq;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Features
{
    public class CupomORM : RepositoryBase<Cupom>, ICupomRepository
    {
        public CupomORM(LocadoraDeVeiculosDBContext db) : base(db)
        {
        }
        public void AtualizarQtdUtilizada(Cupom cupom)
        {
            cupom.QtdUtilizada++;
            try
            {
                db.ChangeTracker.Clear();
                dbSet.Update(cupom);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Selecionar Por Código um(a) {Feature} / Layer: Repository / Id Processo: {IdProcesso} / User: IdUsuario Tempo: ?? / Sql: query / {StackTrace}", DateTime.Now, this.ToString(), cupom.Id, cupom.QtdUtilizada, ex);
            }
        }

        public bool ExisteCodigo(string codigo)
        {
            try
            {
                return dbSet.ToList().Exists(x => x.Codigo == codigo);
            }
            catch (Exception ex)
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Verificar se Existe o Código o(a) {Feature} / Layer: Repository / User: IdUsuario Tempo: ?? / Sql: query / {StackTrace}", DateTime.Now, this.ToString(),  ex);
                return false;
            }
        }

        public Cupom SelecionarPorCodigo(string codigo)
        {
            try
            {
                return dbSet.FirstOrDefault(x => x.Codigo.Equals(codigo));
            }
            catch (Exception ex)
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Selecionar Por Id um(a) {Feature} / Layer: Repository / Id Processo: {IdProcesso} / User: IdUsuario / Sql: query / {StackTrace}", DateTime.Now, this.ToString(), ex);
                return null;
            }
        }
    }
}
