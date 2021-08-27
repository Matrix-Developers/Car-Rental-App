using LocadoraDeVeiculos.Controladores.LocacaoModule;
using LocadoraDeVeiculos.Dominio.LocacaoModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Devolucoes
{
    public class OperacoesDevolucao : ICadastravel
    {
        private readonly ControladorLocacao controlador = null;
        private readonly TabelaDevolucaoControl tabelaDevolucao = null;
        public OperacoesDevolucao(ControladorLocacao ctrlDevolucao)
        {
            controlador = ctrlDevolucao;
            tabelaDevolucao = new TabelaDevolucaoControl();
        }
        public void InserirNovoRegistro()
        {
            TelaDevolucaoForm tela = new TelaDevolucaoForm("Devolução de Veículo");
            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Devolucao);
                List<Locacao> funcionarios = controlador.SelecionarTodos();
                tabelaDevolucao.AtualizarRegistros(funcionarios);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Devolução: [{tela.Devolucao.Id}] realizada com sucesso");
            }
        }

        public void EditarRegistro()
        {
            throw new NotImplementedException();
        }

        public void ExcluirRegistro()
        {
            int id = tabelaDevolucao.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um registro de Devolução para poder excluir!", "Exclusão de Registro",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Locacao locacaoSelecionada = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir todo o registro da locação e devolução: [{locacaoSelecionada.Id}] ?",
                "Exclusão de Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<Locacao> veiculos = controlador.SelecionarTodos();

                tabelaDevolucao.AtualizarRegistros(veiculos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Registro de: [{locacaoSelecionada.ClienteContratante}] removida com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public UserControl ObterTabela()
        {
            throw new NotImplementedException();
        }
    }
}
