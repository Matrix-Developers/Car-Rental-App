using LocadoraDeVeiculos.Dominio.RelacionamentoLocServModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Aplicacao.RelacionamentoLocServModule
{
    public class RelacionamentoLocServAppService //nao está sendo usado. estamos utilizando diretamente o appService
    {
        private readonly IRepository<RelacionamentoLocServ> relacionamentoLocServRepository;

        public RelacionamentoLocServAppService(IRepository<RelacionamentoLocServ> relacionamentoLocServRepository)
        {
            this.relacionamentoLocServRepository = relacionamentoLocServRepository;
        }
        
        public string InserirNovoRelacionamentoLocServ(RelacionamentoLocServ relacionamentoLocServ)
        {
            string resultadoValidacao = relacionamentoLocServ.Validar();

            if (resultadoValidacao == "VALID")
                relacionamentoLocServRepository.InserirNovo(relacionamentoLocServ);

            return resultadoValidacao;
        }
        public string EditarRelacionamentoLocServ(int id, RelacionamentoLocServ relacionamentoLocServ)
        {
            throw new NotImplementedException();
        }
        public bool ExcluirRelacionamentoLocServ(int id) { return relacionamentoLocServRepository.Excluir(id); }
        public bool ExisteRelacionamentoLocServ(int id) { return relacionamentoLocServRepository.Existe(id); }
        public RelacionamentoLocServ SelecionarRelacionamentoLocServPorId(int id) { return relacionamentoLocServRepository.SelecionarPorId(id); }
        public List<RelacionamentoLocServ> SelecionarTodosRelacionamentoLocServ() { return relacionamentoLocServRepository.SelecionarTodos(); }

    }
}
