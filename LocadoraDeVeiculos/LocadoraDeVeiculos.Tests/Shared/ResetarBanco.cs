using LocadoraDeVeiculos.Controladores.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.IntegrationTests.Shared
{
    public static class ResetarBanco
    {    
        public static void ResetarTabelas()
        {
            Db.Update("DELETE [TBSERVICO_LOCACAO]");
            Db.Update("DELETE [TBLOCACAO]");
            Db.Update("DELETE [TBGRUPOVEICULO]");
            Db.Update("DELETE [TBIMAGEMVEICULO]");
            Db.Update("DELETE [TBVEICULO]");            
            Db.Update("DELETE [TBFUNCIONARIO]");
            Db.Update("DELETE [TBSERVICO]");            
            Db.Update("DELETE [TBCLIENTE]");
            Db.Update("DELETE FROM [TBCUPOM_DESCONTO]");
            Db.Update("DELETE FROM [TBPARCEIRO]");            

            Db.Update("DBCC CHECKIDENT('TBSERVICO_LOCACAO', RESEED, 0)");
            Db.Update("DBCC CHECKIDENT('TBLOCACAO', RESEED, 0)");
            Db.Update("DBCC CHECKIDENT('TBGRUPOVEICULO', RESEED, 0)");
            Db.Update("DBCC CHECKIDENT('TBIMAGEMVEICULO', RESEED, 0)");
            Db.Update("DBCC CHECKIDENT('TBVEICULO', RESEED, 0)");            
            Db.Update("DBCC CHECKIDENT('TBFUNCIONARIO', RESEED, 0)");
            Db.Update("DBCC CHECKIDENT('TBSERVICO', RESEED, 0)");
            Db.Update("DBCC CHECKIDENT('TBCLIENTE', RESEED, 0)");
            Db.Update("DBCC CHECKIDENT('TBCUPOM_DESCONTO', RESEED, 0)");
            Db.Update("DBCC CHECKIDENT('TBPARCEIRO', RESEED, 0)");
        }
    }
}
