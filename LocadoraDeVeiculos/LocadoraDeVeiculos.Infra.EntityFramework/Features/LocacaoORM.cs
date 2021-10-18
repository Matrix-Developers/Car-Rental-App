using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.EntityFramework.Shared;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LocadoraDeVeiculos.Infra.EntityFramework.Features
{
    public class LocacaoORM : RepositoryBase<Locacao>, IRepository<Locacao>
    {
        public LocacaoORM(LocadoraDeVeiculosDBContext db) : base(db)
        {
        }
        public override bool Editar(int id, Locacao registro)
        {
            try
            {
                Locacao registroAuxiliar = new();
                registroAuxiliar.Servicos = registro.Servicos;
                db.SaveChanges();
                registroAuxiliar.Id = 0;

                Locacao entityForUpdate = dbSet.Include(x => x.Servicos).SingleOrDefault(x => x.Id.Equals(id));
                registro.Id = id;
                db.Entry(entityForUpdate).CurrentValues.SetValues(registro);

                foreach (Servico servico in registro.Servicos){
                    entityForUpdate.Servicos.Remove(servico);
                }
                    db.SaveChanges();
                foreach (Servico servico in registroAuxiliar.Servicos){
                    entityForUpdate.Servicos.Add(servico);
                }
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Log.Error("{DataEHora} / Ocorreu um erro ao tentar Editar  um(a) {Feature} / Camada: Repository / Id Processo: {IdProcesso} / Usuário: IdUsuario / Sql: query / {StackTrace}", DateTime.Now, this.ToString(), registro.Id, ex);
                return false;
            }
            return true;
        }

        public override List<Locacao> SelecionarTodos()
        {
            return db.Locacoes
                .Include(x => x.FuncionarioLocador)
                .Include(x => x.ClienteContratante)
                .Include(x => x.ClienteCondutor)
                .Include(x => x.Cupom)
                .Include(x => x.Servicos)
                .Include(x => x.Veiculo)
                .ThenInclude(x => x.grupoVeiculos)
                .ToList<Locacao>(); //SingleOrDefault(x => x.Id == id);
        }

        public override Locacao SelecionarPorId(int id)
        {
            return db.Locacoes
                .Include(x => x.FuncionarioLocador)
                .Include(x => x.ClienteContratante)
                .Include(x => x.ClienteCondutor)
                .Include(x => x.Cupom)
                .Include(x => x.Servicos)
                .Include(x => x.Veiculo)
                .ThenInclude(x => x.grupoVeiculos)
                .SingleOrDefault(x => x.Id == id);
        }
    }
}
