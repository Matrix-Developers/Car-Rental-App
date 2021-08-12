using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace LocadoraDeVeiculos.Controladores.GrupoDeVeiculosModule
{
    public class ControladorGrupoDeVeiculos : Controlador<GrupoDeVeiculos>
    {
        //Nota: nome da tabela "TBGRUPOVEICULO" é incosistente com o nome das outras tabelas do banco.
        //      - talvez considerar renomear "TBGRUPOVEICULO" para "TBGRUPODEVEICULOS"
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
            var parametros = new Dictionary<string, object>();

            parametros.Add("Id", grupoDeVeiculos.Id);
            parametros.Add("Nome", grupoDeVeiculos.Nome);
            parametros.Add("TaxaPlanoDiario", grupoDeVeiculos.TaxaPlanoDiario);
            parametros.Add("TaxaKmControlado", grupoDeVeiculos.TaxaKmControlado);
            parametros.Add("TaxaKmLivre", grupoDeVeiculos.TaxaKmLivre);
            parametros.Add("QuantidadeQuilometrosKmControlado", grupoDeVeiculos.QuantidadeQuilometrosKmControlado);

            return parametros;
        }

        private GrupoDeVeiculos ConverterEmGrupoDeVeiculos(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["Id"]); ;
            string nome = Convert.ToString(reader["Nome"]); ;
            float taxaPlanoDiario = (float)Convert.ToDouble(reader["TaxaPlanoDiario"]);
            float taxaKmControlado = (float)Convert.ToDouble(reader["TaxaKmControlado"]);
            float taxaKmLivre = (float)Convert.ToDouble(reader["TaxaKmLivre"]);
            int quantidadeQuilometrosKmControlado = Convert.ToInt32(reader["QuantidadeQuilometrosKmControlado"]);

            GrupoDeVeiculos grupoDeVeiculos = new GrupoDeVeiculos(id, nome, taxaPlanoDiario, taxaKmControlado, taxaKmLivre, quantidadeQuilometrosKmControlado);

            return grupoDeVeiculos;
        }
    }
}
