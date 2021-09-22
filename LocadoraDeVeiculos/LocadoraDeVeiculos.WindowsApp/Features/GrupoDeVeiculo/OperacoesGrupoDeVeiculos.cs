using LocadoraDeVeiculos.Aplicacao.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.Dominio.GrupoDeVeiculosModule;
using LocadoraDeVeiculos.WindowsApp.GrupoDeVeiculos;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.GrupoDeVeiculos
{
    public class OperacoesGrupoDeVeiculos : ICadastravel
    {
        private readonly GrupoDeVeiculosAppService grupoDeVeiculosAppService;
        private readonly TabelaGrupoDeVeiculosControl tabelaGrupoDeVeiculos;

        public OperacoesGrupoDeVeiculos(GrupoDeVeiculosAppService GrupoDeVeiculosAppService)
        {
            grupoDeVeiculosAppService = GrupoDeVeiculosAppService;
            tabelaGrupoDeVeiculos = new TabelaGrupoDeVeiculosControl();
        }
        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void EditarRegistro()
        {
            int id = tabelaGrupoDeVeiculos.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Grupo de Veiculos para poder editar!", "Edição de Grupo de Veiculos",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            GrupoDeVeiculo grupoSelecionado = grupoDeVeiculosAppService.SelecionarGrupoDeVeiculoPorId(id);

            TarefaGrupoDeVeiculosForm tela = new("Edição de Grupo de Veiculos");

            tela.GrupoDeVeiculos = grupoSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                grupoDeVeiculosAppService.EditarGrupoDeVeiculo(id, tela.GrupoDeVeiculos);

                List<GrupoDeVeiculo> grupoDeVeiculos = grupoDeVeiculosAppService.SelecionarTodosGrupoDeVeiculo();

                tabelaGrupoDeVeiculos.AtualizarRegistros(grupoDeVeiculos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Grupo de Veículos: [{tela.GrupoDeVeiculos.Nome}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabelaGrupoDeVeiculos.ObtemIdSelecionado();
            if (id == 0)
            {
                MessageBox.Show("Selecione um Grupo de Veículos para excluir", "Exclusão de Grupo de Veículos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            GrupoDeVeiculo grupoSelecionado = grupoDeVeiculosAppService.SelecionarGrupoDeVeiculoPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o Grupo de Veículos: [{grupoSelecionado.Nome}]?",
                "Exclusão de Grupo de Veículos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                grupoDeVeiculosAppService.ExcluirGrupoDeVeiculo(id);

                List<GrupoDeVeiculo> grupos = grupoDeVeiculosAppService.SelecionarTodosGrupoDeVeiculo();

                tabelaGrupoDeVeiculos.AtualizarRegistros(grupos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Grupo de Veículos: [{grupoSelecionado.Nome}]removido com sucesso");
            }
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void InserirNovoRegistro()
        {
            TarefaGrupoDeVeiculosForm tela = new("Cadastro de Grupo de Veiculos");

            if (tela.ShowDialog() == DialogResult.OK)
            {
                grupoDeVeiculosAppService.InserirNovoGrupoDeVeiculo(tela.GrupoDeVeiculos);

                List<GrupoDeVeiculo> grupoDeVeiculos = grupoDeVeiculosAppService.SelecionarTodosGrupoDeVeiculo();

                tabelaGrupoDeVeiculos.AtualizarRegistros(grupoDeVeiculos);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Grupo de Veículos: [{tela.GrupoDeVeiculos.Nome}] inserido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<GrupoDeVeiculo> grupoDeVeiculos = grupoDeVeiculosAppService.SelecionarTodosGrupoDeVeiculo();
            tabelaGrupoDeVeiculos.AtualizarRegistros(grupoDeVeiculos);

            return tabelaGrupoDeVeiculos;
        }
    }
}
