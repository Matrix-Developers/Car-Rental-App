using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.RelacionamentoLocServModule
{
    public class RelacionamentoLocServ : EntidadeBase<int>
    {
        public Locacao Locacao { get; }
        public List<Servico> Servicos { get; }
        public int idServico { get; }

        public RelacionamentoLocServ(int id, Locacao locacao, List<Servico> servicos)
        {
            this.id = id;
            Locacao = locacao;
            Servicos = servicos;
        }

        public RelacionamentoLocServ(int id, Locacao locacao, int idServico)
        {
            this.id = id;
            Locacao = locacao;
            this.idServico = idServico;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";
            if (Locacao.id == 0)
                resultadoValidacao = "ID de locação inválido";
            if (Servicos == null)
                resultadoValidacao = "Nenhum serviço selecionado";
            if (resultadoValidacao == "")
                resultadoValidacao = "VALIDO";
            return resultadoValidacao;
        }

        public override int GetHashCode()
        {
            int hashCode = 1438320420;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Locacao>.Default.GetHashCode(Locacao);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Servico, int>>.Default.GetHashCode(Servicos);
            return hashCode;
        }
        public override string ToString()
        {
            return $"{id} {Locacao} {Servicos}";
        }

        public override bool Equals(object obj)
        {
            return obj is RelacionamentoLocServ serv &&
                   id == serv.id &&
                   EqualityComparer<Locacao>.Default.Equals(Locacao, serv.Locacao) &&
                   EqualityComparer<List<Servico, int>>.Default.Equals(Servicos, serv.Servicos);
        }
    }
}
