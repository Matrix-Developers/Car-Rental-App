using LocadoraDeVeiculos.Dominio.RelacionamentoLocServModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Aplicacao.RelacionamentoLocServModule
{
    public class RelacionamentoLocServAppService
    {
        private readonly IRepository<RelacionamentoLocServ> relacionamentoLocServRepository;

        public string InserirNovoRelacionamentoLocServ(RelacionamentoLocServ relacionamentoLocServ){
            string resultadoValidacao = relacionamentoLocServ.Validar();

            if (resultadoValidacao == "VALIDO")
                relacionamentoLocServRepository.InserirNovo(relacionamentoLocServ);

            return resultadoValidacao;
        }
        public string EditarRelacionamentoLocServ(int id, RelacionamentoLocServ relacionamentoLocServ)
        {
            throw new NotImplementedException();
        }
        public bool ExcluirRelacionamentoLocServ(int id) { return relacionamentoLocServRepository.Excluir(id);}
        public bool ExisteRelacionamentoLocServ(int id) { return relacionamentoLocServRepository.Existe(id);}
        public RelacionamentoLocServ SelecionarRelacionamentoLocServPorId(int id) { return relacionamentoLocServRepository.SelecionarPorId(id);}
        public List<RelacionamentoLocServ> SelecionarTodosRelacionamentoLocServ() { return relacionamentoLocServRepository.SelecionarTodos();}

    }
}
