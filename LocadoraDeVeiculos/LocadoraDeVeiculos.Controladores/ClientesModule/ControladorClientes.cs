using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Controladores.ClientesModule
{
    public class ControladorCliente
    {
        #region Queries
            private const string sqlInserirClientes =
            @"
               INSERT INTO [TBCLIENTE]
            (
	            [NOME],
	            [REGISTROUNICO],
	            [ENDERECO],
	            [TELEFONE],
	            [EMAIL],
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

		private const string sqlEditarClientes =
		@"
				UPDATE [TBCLIENTE] 
				 SET
					[NOME] = @NOME,
					[REGISTROUNICO] = @REGISTROUNICO,
					[ENDERECO] = @ENDERECO,
					[TELEFONE] = @TELEFONE,
					[EMAIL] = @EMAIL,
					[EHPESSOAFISICA] = @EHPESSOAFISICA,
					[CNH] = @CNH,
					[VALIDADECNH] = @VALIDADECNH
				WHERE [ID] = @ID;
            )";

		private const string sqlExcluirClientes =
		@"
				DELETE FROM [TBCLIENTE] WHERE [ID] = @ID
			";

		private const string sqlSelecionarTodosClientes =
		@"
			SELECT * FROM [TBCLIENTE]
			";

		private const string sqlSelecionarPorId =
		@"
			SELECT * FROM [TBCLIENTE] WHERE [ID] = @ID;
			";

			private const string sqlExisteCliente =
			@"SELECT 
                COUNT(*) 
            FROM 
                [TBCLIENTE]
            WHERE 
                [ID] = @ID";
		#endregion
	}
}
