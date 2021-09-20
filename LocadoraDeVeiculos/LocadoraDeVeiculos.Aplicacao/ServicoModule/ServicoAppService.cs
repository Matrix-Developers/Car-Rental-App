using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Aplicacao.ServicoModule
{
    public class ServicoAppService
    {
        private readonly IRepository<Servico> servicoRepository;

        public ServicoAppService(IRepository<Servico> servicoRepository)
        {
            this.servicoRepository = servicoRepository;
        }

        public string InserirNovoServico(Servico servico) {
            string resultadoValidacao = servico.Validar();

            if (resultadoValidacao == "VALIDO")
                servicoRepository.InserirNovo(servico);

            return resultadoValidacao;
        }
        public string EditarServico(int id,Servico servico)
        {
            string resultadoValidacao = servico.Validar();

            if (resultadoValidacao == "VALIDO")
                servicoRepository.Editar(id,servico);

            return resultadoValidacao;
        }
        public bool ExcluirServico(int id) { return servicoRepository.Excluir(id);}
        public bool ExisteServico(int id) { return servicoRepository.Existe(id);}
        public Servico SelecionarServicoPorId(int id) { return servicoRepository.SelecionarPorId(id);}
        public List<Servico> SelecionarTodosServico() { return servicoRepository.SelecionarTodos();}
    }
}
