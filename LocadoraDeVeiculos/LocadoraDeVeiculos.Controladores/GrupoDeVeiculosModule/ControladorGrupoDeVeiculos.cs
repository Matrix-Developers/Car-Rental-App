using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace LocadoraDeVeiculos.Controladores.GrupoDeVeiculosModule
{
    public class ControladorGrupoDeVeiculos : Controlador<GrupoDeVeiculos>
    {
        private const string sqlInserirGrupoDeVeiculos =
                @"INSERT INTO TBGRUPOVEICULO
                (
	                [Nome],
	                [TaxaPlanoDiario],
	                [TaxaKmControlado],
	                [TaxaKmLivre],
	                [QuantidadeQuilometrosKmControlado]
                )
                VALUES
                (
	                @Nome,
	                @TaxaPlanoDiario,
	                @TaxaKmControlado,
	                @TaxaKmLivre,
	                @QuantidadeQuilometrosKmControlado
                );";

        private const string sqlEditarGrupoDeVeiculos =
                @"UPDATE TBGRUPOVEICULO 
                SET
	                [Nome] = @Nome,
	                [TaxaPlanoDiario] = @TaxaPlanoDiario,
	                [TaxaKmControlado] = @TaxaKmControlado,
	                [TaxaKmLivre] = @TaxaKmLivre,
	                [QuantidadeQuilometrosKmControlado] = @QuantidadeQuilometrosKmControlado
                WHERE [Id] = @Id;";

        private const string sqlExcluirGrupoDeVeiculos =
                @"DELETE FROM TBGRUPOVEICULO  WHERE [Id] = @Id;";

        private const string sqlSelecionarGrupoDeVeiculosPorId =
                @"SELECT * FROM TBGRUPOVEICULO WHERE [Id] = @Id;";

        private const string sqlSelecionarTodosGrupoDeVeiculoss =
                @"SELECT * FROM TBGRUPOVEICULO;";

        private const string sqlExisteGrupoDeVeiculos =
                @"SELECT 
                    COUNT(*) 
                FROM 
                    [TBGRUPOVEICULO]
                WHERE 
                    [Id] = @Id";

        public override string InserirNovo(GrupoDeVeiculos registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirGrupoDeVeiculos, ObtemParametrosGrupoDeVeiculos(registro));
            }

            return resultadoValidacao;
        }

        public override string Editar(int id, GrupoDeVeiculos registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarGrupoDeVeiculos, ObtemParametrosGrupoDeVeiculos(registro));
            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                Db.Delete(sqlExcluirGrupoDeVeiculos, AdicionarParametro("ID", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return Db.Exists(sqlExisteGrupoDeVeiculos, AdicionarParametro("ID", id));
        }

        public override GrupoDeVeiculos SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarGrupoDeVeiculosPorId, ConverterEmGrupoDeVeiculos, AdicionarParametro("ID", id));
        }

        public override List<GrupoDeVeiculos> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosGrupoDeVeiculoss, ConverterEmGrupoDeVeiculos);
        }

        private Dictionary<string, object> ObtemParametrosGrupoDeVeiculos(GrupoDeVeiculos grupoDeVeiculos)
        {
            throw new NotImplementedException();
        }

        private GrupoDeVeiculos ConverterEmGrupoDeVeiculos(IDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
