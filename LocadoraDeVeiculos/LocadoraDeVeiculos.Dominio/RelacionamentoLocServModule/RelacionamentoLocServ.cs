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

        public RelacionamentoLocServ(int id, Locacao locacao, List<Servico> servicos)
        {
            this.Id = id;
            Locacao = locacao;
            Servicos = servicos;
        }

        public override string Validar()
        {
            string resultadoValidacao = "";
            if (Locacao.Id == 0)
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
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Locacao>.Default.GetHashCode(Locacao);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Servico>>.Default.GetHashCode(Servicos);
            return hashCode;
        }
        public override string ToString()
        {
            return $"{id} {Locacao} {Servicos}";
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
