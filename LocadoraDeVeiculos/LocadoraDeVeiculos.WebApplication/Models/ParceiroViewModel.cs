using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.WebApplication.Models
{
    public class ParceiroViewModel
    {

        #region list
        public class ParceiroListViewModel
        {
            public int Id { get; set; }

            public string Nome { get; set; }
        }

        public class ParceiroIndexViewModel : ITituloViewModel
        {
            public string Titulo => "Parceiro";

            public List<ParceiroListViewModel> registros { get; set; }


        }

        #endregion

        #region input
        public class ParceiroInputViewModel
        {
            [Required(ErrorMessage = "O campo {0} é obrigatório")]
            [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} digitos", MinimumLength = 2)]
            public string Nome { get; set; }
        }

        public class ParceiroCreateViewModel : ParceiroInputViewModel, ITituloViewModel
        {
            public string Titulo => "Cadastro de Parceiros";

        }

        public class ParceiroEditViewModel : ParceiroInputViewModel, ITituloViewModel
        {
            public string Titulo => "Edição de parceiro";

            [Key]
            public int Id { get; set; }

        }


        #endregion

        #region info
        public abstract class ParceiroInfoViewModel
        {
            public int Id { get; set; }

            public string Nome { get; set; }
        }
        public class ParceiroDetailsViewModel : ParceiroInfoViewModel, ITituloViewModel
        {
            public string Titulo => "Dados do Parceiro";
        }
        public class ParceiroDeleteViewModel : ParceiroInfoViewModel, ITituloViewModel
        {
            public string Titulo => "Exclusão de Parceiro";
        }

        #endregion

    }
}
