using LocadoraDeVeiculos.Controladores.Shared;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraDeVeiculos.Controladores.ServicoLocacaoModule
{
    public class ControladorServicoLocacao : Controlador<ServicoLocacao>
    {
        public override string Editar(int id, Servico registro)
        {
            throw new NotImplementedException();
        }

        public override bool Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Existe(int id)
        {
            throw new NotImplementedException();
        }

        public override string InserirNovo(List<Servico> registro)
        {
            throw new NotImplementedException();
        }

        public override Servico SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Servico> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
