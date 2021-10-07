using LocadoraDeVeiculos.Dominio.ClienteModule;
using LocadoraDeVeiculos.Dominio.Shared;
using LocadoraDeVeiculos.Infra.SQL.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace LocadoraDeVeiculos.Controladores.ClientesModule
{
    public class ClienteRepository : RepositoryBase<Cliente>, IRepository<Cliente, int>
    {
        #region queries
        protected override string SqlInserirEntidade
        {
            get
            {
                return
                    @"INSERT INTO [TBCLIENTE]
					(
					    [NOME],
					    [REGISTROUNICO],
					    [ENDERECO],
					    [EMAIL],
					    [TELEFONE],
					    [EHPESSOAFISICA],
					    [CNH],
					    [VALIDADECNH]
					)
					VALUES
					(
					    @NOME,
					    @REGISTROUNICO,
					    @ENDERECO,
					    @EMAIL,
					    @TELEFONE,
					    @EHPESSOAFISICA,
					    @CNH,
					    @VALIDADECNH
					)";
            }
        }
        protected override string SqlEditarEntidade
        {
            get
            {
                return
                    @"UPDATE [TBCLIENTE] 
					SET
						[NOME] = @NOME,
						[REGISTROUNICO] = @REGISTROUNICO,
						[ENDERECO] = @ENDERECO,
						[TELEFONE] = @TELEFONE,
						[EMAIL] = @EMAIL,
						[EHPESSOAFISICA] = @EHPESSOAFISICA,
						[CNH] = @CNH,
						[VALIDADECNH] = @VALIDADECNH
					WHERE [ID] = @ID;";
            }
        }
        protected override string SqlExcluirEntidade
        {
            get
            {
                return
                    @"DELETE FROM [TBCLIENTE] WHERE [ID] = @ID";
            }
        }
        protected override string SqlSelecionarEntidadePorId
        {
            get
            {
                return
                    @"SELECT * FROM [TBCLIENTE] WHERE [ID] = @ID;";
            }
        }
        protected override string SqlSelecionarTodasEntidades
        {
            get
            {
                return
                    @" SELECT * FROM [TBCLIENTE]";
            }
        }
        protected override string SqlExisteEntidade
        {
            get
            {
                return
                    @"SELECT COUNT(*) FROM [TBCLIENTE] WHERE [ID] = @ID";
            }
        }
        #endregion

        protected override Dictionary<string, object> ObtemParametros(Cliente entidade)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", entidade.id },
                { "NOME", entidade.Nome },
                { "REGISTROUNICO", entidade.RegistroUnico },
                { "ENDERECO", entidade.Endereco },
                { "TELEFONE", entidade.Telefone },
                { "EMAIL", entidade.Email },
                { "CNH", entidade.Cnh },
                { "VALIDADECNH", entidade.ValidadeCnh },
                { "EHPESSOAFISICA", entidade.EhPessoaFisica }
            };

            return parametros;
        }
        protected override Cliente ConverterEmEntidade(IDataReader reader)
        {
            DateTime? validadeCnh = null;
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString((reader["NOME"]));
            string registroUnico = Convert.ToString((reader["REGISTROUNICO"]));
            string endereco = Convert.ToString(reader["ENDERECO"]);
            string telefone = Convert.ToString(reader["TELEFONE"]);
            string email = Convert.ToString(reader["EMAIL"]);
            string cnh = Convert.ToString(reader["CNH"]);
            if (reader["VALIDADECNH"] != DBNull.Value)
                validadeCnh = Convert.ToDateTime(reader["VALIDADECNH"]);
            bool ehPessoaFisica = Convert.ToBoolean(reader["EHPESSOAFISiCA"]);

            Cliente cliente = new(id, nome, registroUnico, endereco, telefone, email, cnh, validadeCnh, ehPessoaFisica)
            {
                id = id
            };
            return cliente;
        }
    }
}
