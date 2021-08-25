using LocadoraDeVeiculos.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Locacoes
{
    public class OperacoesLocacao : ICadastravel
    {
        //private readonly ControladorLocacao controlador = null;
        private readonly TabelaLocacaoControl tabelaLocacao = null;
        //public OperacoesVeiculo(ControladorLocacao ctrlLocacao)
        //{
        //    //controlador = ctrlLocacao;
        //    tabelaLocacao = new TabelaLocacaoControl();
        //}

        public void InserirNovoRegistro()
        {
            TelaLocacaoForm tela = new TelaLocacaoForm("Locação de Veiculos");

            if (tela.ShowDialog() == DialogResult.OK)
            {

                //controlador.InserirNovo(tela.Veiculo);

                //List<Veiculo> veiculos = controlador.SelecionarTodos();

                //tabelaLocacao.AtualizarRegistros(veiculos);

                //TelaPrincipalForm.Instancia.AtualizarRodape($"Veiculo: [{tela.Veiculo.modelo}] inserido com sucesso");
            }
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void EditarRegistro()
        {
            throw new NotImplementedException();
        }

        public void ExcluirRegistro()
        {
            throw new NotImplementedException();
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        

        public UserControl ObterTabela()
        {
            throw new NotImplementedException();
        }
    }
}
