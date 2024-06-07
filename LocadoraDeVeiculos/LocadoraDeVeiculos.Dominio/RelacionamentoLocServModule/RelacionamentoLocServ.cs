using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.Dominio.SevicosModule;
using LocadoraDeVeiculos.Dominio.Shared;
using System.Collections.Generic;

namespace LocadoraDeVeiculos.Dominio.RelacionamentoLocServModule
{
    public class RelacionamentoLocServ : EntidadeBase
    {
        public Locacao Locacao { get; }
        public List<Servico> Servicos { get; }
        public int IdServico { get; }
        public int IdLocacao { get; }

        public RelacionamentoLocServ(int id, Locacao locacao, List<Servico> servicos)
        {
            this.Id = id;
            Locacao = locacao;
            Servicos = servicos;
        }

        public RelacionamentoLocServ(int id, Locacao locacao, int IdServico)
        {
            this.Id = id;
            Locacao = locacao;
            this.IdServico = IdServico;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";
            if (Locacao.Id == 0)
                resultadoValidacao = "Invalid rental ID.";
            if (Servicos == null)
                resultadoValidacao = "No services selected.";
            if (resultadoValidacao == "")
                resultadoValidacao = "VALID";
            return resultadoValidacao;
        }

        public override int GetHashCode()
        {
            int hashCode = 1438320420;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Locacao>.Default.GetHashCode(Locacao);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Servico>>.Default.GetHashCode(Servicos);
            return hashCode;
        }
        public override string ToString()
        {
            return $"{Locacao}, {Servicos}";
        }

        public override bool Equals(object obj)
        {
            return obj is RelacionamentoLocServ serv &&
                   Id == serv.Id &&
                   EqualityComparer<Locacao>.Default.Equals(Locacao, serv.Locacao) &&
                   EqualityComparer<List<Servico>>.Default.Equals(Servicos, serv.Servicos);
        }
    }
}
