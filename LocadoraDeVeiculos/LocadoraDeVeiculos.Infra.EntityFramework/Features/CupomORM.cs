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
        public void AtualizarQtdUtilizada(int id, int qtdUtilizada)
        {
            try
            {
                Cupom cupom = SelecionarPorId(id);
                db.Entry(cupom.QtdUtilizada).CurrentValues.SetValues(qtdUtilizada);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Selecionar Por Código um(a) {Feature} / Camada: Repository / Id Processo: {IdProcesso} / Usuário: IdUsuario Tempo: ?? / Sql: query / {StackTrace}", DateTime.Now, this.ToString(), id, qtdUtilizada, ex);
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
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Verificar se Existe o Código o(a) {Feature} / Camada: Repository / Usuário: IdUsuario Tempo: ?? / Sql: query / {StackTrace}", DateTime.Now, this.ToString(),  ex);
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
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Selecionar Por Id um(a) {Feature} / Camada: Repository / Id Processo: {IdProcesso} / Usuário: IdUsuario / Sql: query / {StackTrace}", DateTime.Now, this.ToString(), ex);
                return null;
            }
        }
    }
}
