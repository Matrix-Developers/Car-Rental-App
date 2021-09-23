using LocadoraDeVeiculos.Aplicacao.VeiculoModule;
using LocadoraDeVeiculos.Dominio.VeiculoModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
using LocadoraDeVeiculos.WindowsApp.Veiculos;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Veiculos
{
    public class OperacoesVeiculo : ICadastravel
    {
        private readonly VeiculoAppService veiculoAppService = null;
        private readonly TabelaVeiculoControl tabelaVeiculo = null;
        public OperacoesVeiculo(VeiculoAppService VeiculoAppService)
        {
            veiculoAppService = VeiculoAppService;
            tabelaVeiculo = new TabelaVeiculoControl();
        }
        public void InserirNovoRegistro()
        {
            VeiculoForm tela = new("Cadastro de Veiculos");

            if (tela.ShowDialog() == DialogResult.OK)
            {
                if (tela.Veiculo.imagens.Count != 0)
                    foreach (Dominio.ImagemVeiculoModule.ImagemVeiculo imagem in tela.Veiculo.imagens)
                        imagem.IdVeiculo = tela.Veiculo.Id;

                veiculoAppService.InserirNovoVeiculo(tela.Veiculo);

                List<Veiculo> veiculos = veiculoAppService.SelecionarTodosVeiculo();

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

            Veiculo tarefaSelecionada = veiculoAppService.SelecionarVeiculoPorId(id);

            VeiculoForm tela = new("Edição de Veiculos");

            tela.Veiculo = tarefaSelecionada;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                veiculoAppService.EditarVeiculo(id, tela.Veiculo);

                List<Veiculo> veiculos = veiculoAppService.SelecionarTodosVeiculo();

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

            Veiculo tarefaSelecionada = veiculoAppService.SelecionarVeiculoPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o veículo: [{tarefaSelecionada.modelo}] ?",
                "Exclusão de Veiculos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                veiculoAppService.ExcluirVeiculo(id);

                List<Veiculo> veiculos = veiculoAppService.SelecionarTodosVeiculo();

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
            List<Veiculo> veiculos = veiculoAppService.SelecionarTodosVeiculo();

            tabelaVeiculo.AtualizarRegistros(veiculos);

            return tabelaVeiculo;
        }
        public void AgruparRegistros()
        {
            throw new System.NotImplementedException();
        }
    }
}
