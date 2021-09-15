using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.SQL.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace LocadoraDeVeiculos.Controladores.GrupoDeVeiculosModule
{
    public class GrupoDeVeiculosRepository : RepositoryBase<GrupoDeVeiculo>, IRepository<GrupoDeVeiculo>
    {
        #region queries
        private const string sqlInserirGrupoDeVeiculos =
                @"INSERT INTO TBGRUPOVEICULO
                (
	                [NOME],
	                [TAXAPLANODIARIO],
	                [TAXAPORKMDIARIO],
	                [TAXAPLANOCONTROLADO],
	                [LIMITEKMCONTROLADO],
	                [TAXAKMEXCEDIDOCONTROLADO],
	                [TAXAPLANOLIVRE]
                )
                VALUES
                (
	                @NOME,
	                @TAXAPLANODIARIO,
	                @TAXAPORKMDIARIO,
	                @TAXAPLANOCONTROLADO,
	                @LIMITEKMCONTROLADO,
	                @TAXAKMEXCEDIDOCONTROLADO,
	                @TAXAPLANOLIVRE
                );";

        private const string sqlEditarGrupoDeVeiculos =
                @"UPDATE TBGRUPOVEICULO 
                SET
	                [NOME] = @NOME,
	                [TAXAPLANODIARIO] = @TAXAPLANODIARIO,
	                [TAXAPORKMDIARIO] = @TAXAPORKMDIARIO,
	                [TAXAPLANOCONTROLADO] = @TAXAPLANOCONTROLADO,
	                [LIMITEKMCONTROLADO] = @LIMITEKMCONTROLADO,
	                [TAXAKMEXCEDIDOCONTROLADO] = @TAXAKMEXCEDIDOCONTROLADO,
	                [TAXAPLANOLIVRE] = @TAXAPLANOLIVRE
                WHERE [ID] = @ID;";

        private const string sqlExcluirGrupoDeVeiculos =
                @"DELETE FROM TBGRUPOVEICULO  WHERE [ID] = @ID;";

        private const string sqlSelecionarGrupoDeVeiculosPorId =
                @"SELECT * FROM TBGRUPOVEICULO WHERE [ID] = @ID;";

        private const string sqlSelecionarTodosGrupoDeVeiculoss =
                @"SELECT * FROM TBGRUPOVEICULO;";

        private const string sqlExisteGrupoDeVeiculos =
                @"SELECT 
                    COUNT(*) 
                FROM 
                    [TBGRUPOVEICULO]
                WHERE 
                    [ID] = @ID";
        #endregion

        public string InserirNovo(GrupoDeVeiculo registro)
        {
            string resultadoValidacao = registro.Validar();

            List<GrupoDeVeiculo> grupoDeVeiculosRegistrados = SelecionarTodos();
            foreach (GrupoDeVeiculo grupo in grupoDeVeiculosRegistrados)
            {
                if (registro.Nome == grupo.Nome)
                    resultadoValidacao = "O nome do grupo de veículos deve ser único\n";
            }

            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = Db.Insert(sqlInserirGrupoDeVeiculos, ObtemParametros(registro));
            }

            return resultadoValidacao;
        }
        public string Editar(int id, GrupoDeVeiculo registro)
        {
            string resultadoValidacao = registro.Validar();

            List<GrupoDeVeiculo> grupoDeVeiculosRegistrados = SelecionarTodos();
            foreach (GrupoDeVeiculo grupo in grupoDeVeiculosRegistrados)
            {
                if (id != grupo.Id && registro.Nome == grupo.Nome)
                    resultadoValidacao = "O nome do grupo de veículos deve ser único\n";
            }

            if (resultadoValidacao == "VALIDO")
            {
                registro.Id = id;
                Db.Update(sqlEditarGrupoDeVeiculos, ObtemParametros(registro));
            }

            return resultadoValidacao;
        }
        public bool Excluir(int id)
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
        public bool Existe(int id)
        {
            return Db.Exists(sqlExisteGrupoDeVeiculos, AdicionarParametro("ID", id));
        }
        public GrupoDeVeiculo SelecionarPorId(int id)
        {
            return Db.Get(sqlSelecionarGrupoDeVeiculosPorId, ConverterEmEntidade, AdicionarParametro("ID", id));
        }
        public List<GrupoDeVeiculo> SelecionarTodos()
        {
            return Db.GetAll(sqlSelecionarTodosGrupoDeVeiculoss, ConverterEmEntidade);
        }

        protected override Dictionary<string, object> ObtemParametros(GrupoDeVeiculo entidade)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("ID", entidade.Id);
            parametros.Add("NOME", entidade.Nome);
            parametros.Add("TAXAPLANODIARIO", entidade.TaxaPlanoDiario);
            parametros.Add("TAXAPORKMDIARIO", entidade.TaxaPorKmDiario);
            parametros.Add("TAXAPLANOCONTROLADO", entidade.TaxaPlanoControlado);
            parametros.Add("LIMITEKMCONTROLADO", entidade.LimiteKmControlado);
            parametros.Add("TAXAKMEXCEDIDOCONTROLADO", entidade.TaxaKmExcedidoControlado);
            parametros.Add("TAXAPLANOLIVRE", entidade.TaxaPlanoLivre);

            return parametros;
        }
        protected override GrupoDeVeiculo ConverterEmEntidade(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]); ;
            string nome = Convert.ToString(reader["NOME"]); ;
            double taxaPlanoDiario = Convert.ToDouble(reader["TAXAPLANODIARIO"]);
            double taxaPorKmDiario = Convert.ToDouble(reader["TAXAPORKMDIARIO"]);
            double taxaPlanoControlado = Convert.ToDouble(reader["TAXAPLANOCONTROLADO"]);
            int limiteKmControlado = Convert.ToInt32(reader["LIMITEKMCONTROLADO"]);
            double taxaKmExcedidoControlado = Convert.ToDouble(reader["TAXAKMEXCEDIDOCONTROLADO"]);
            double taxaPlanoLivre = Convert.ToDouble(reader["TAXAPLANOLIVRE"]);

            GrupoDeVeiculo grupoDeVeiculos = new GrupoDeVeiculo(id, nome, taxaPlanoDiario, taxaPorKmDiario, taxaPlanoControlado,
                limiteKmControlado, taxaKmExcedidoControlado,taxaPlanoLivre);

            return grupoDeVeiculos;
        }
    }
}
