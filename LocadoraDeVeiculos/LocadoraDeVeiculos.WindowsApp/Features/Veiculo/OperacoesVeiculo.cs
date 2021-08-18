using LocadoraDeVeiculos.Controladores.VeiculoModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
using LocadoraDeVeiculos.WindowsApp.Veiculos;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Veiculos
{
    public class OperacoesVeiculo : ICadastravel
    {
        private readonly ControladorVeiculo controlador = null;
        private readonly TabelaVeiculoControl tabelaVeiculo = null;
        public OperacoesVeiculo(ControladorVeiculo ctrlVeiculo)
        {
            controlador = ctrlVeiculo;
            tabelaVeiculo = new TabelaVeiculoControl();
        }
        public void InserirNovoRegistro()
        {
            VeiculoForm tela = new VeiculoForm();

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Veiculo);

                List<Veiculo> veiculos = controlador.SelecionarTodos();

                tabelaVeiculo.AtualizarRegistros(veiculos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Veiculo: [{tela.Veiculo.modelo}] inserido com sucesso");
            }
        }
        public void EditarRegistro()
        {
            int id = tabelaVeiculo.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um veiculo para poder editar!", "Edição de Veiculos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Veiculo tarefaSelecionada = controlador.SelecionarPorId(id);

            VeiculoForm tela = new VeiculoForm();

            tela.Veiculo = tarefaSelecionada;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Veiculo);

                List<Veiculo> veiculos = controlador.SelecionarTodos();

                tabelaVeiculo.AtualizarRegistros(veiculos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Veiculo: [{tela.Veiculo.modelo}] editado com sucesso");
            }
        }
        public void ExcluirRegistro()
        {
            int id = tabelaVeiculo.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um veiculo para poder excluir!", "Exclusão de Veiculos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Veiculo tarefaSelecionada = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o veículo: [{tarefaSelecionada.modelo}] ?",
                "Exclusão de Veiculos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                controlador.Excluir(id);

                List<Veiculo> veiculos = controlador.SelecionarTodos();

                tabelaVeiculo.AtualizarRegistros(veiculos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Veiculo: [{tarefaSelecionada.modelo}] removido com sucesso");
            }
        }
        public void FiltrarRegistros()
        {
            throw new System.NotImplementedException();
        }
        public UserControl ObterTabela()
        {
            List<Veiculo> veiculos = controlador.SelecionarTodos();

            tabelaVeiculo.AtualizarRegistros(veiculos);

            return tabelaVeiculo;
        }
        public void AgruparRegistros()
        {
            throw new System.NotImplementedException();
        }
    }
}
