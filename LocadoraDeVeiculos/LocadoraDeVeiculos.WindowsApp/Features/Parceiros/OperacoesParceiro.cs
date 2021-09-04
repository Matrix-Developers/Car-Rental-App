using LocadoraDeVeiculos.Controladores.ParceiroModule;
using LocadoraDeVeiculos.Dominio.ParceiroModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Parceiros
{
    public class OperacoesParceiro : ICadastravel
    {
        private readonly ControladorParceiro controlador;
        private readonly TabelaParceiroControl tabela;

        public OperacoesParceiro(ControladorParceiro controladorParceiro)
        {
            controlador = controladorParceiro;
            tabela = new TabelaParceiroControl();
        }

        public void InserirNovoRegistro()
        {
            TelaParceiroForm tela = new TelaParceiroForm("Cadastro de Parceiro");

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Parceiro);

                List<Parceiro> parceiros = controlador.SelecionarTodos();

                tabela.AtualizarRegistros(parceiros);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Parceiro: [{tela.Parceiro.Nome}] inserido com sucesso");
            }
        }        

        public void EditarRegistro()
        {
            int id = tabela.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Parceiro para poder Editar!", "Edição de Parceiros", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Parceiro funcionarioSelecionado = controlador.SelecionarPorId(id);
            TelaParceiroForm tela = new TelaParceiroForm("Edição de Parceiro");
            tela.Parceiro = funcionarioSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Parceiro);
                List<Parceiro> funcionarios = controlador.SelecionarTodos();
                tabela.AtualizarRegistros(funcionarios);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Parceiro: [{funcionarioSelecionado.Nome}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabela.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Parceiro para excluir", "Exclusão de Parceiro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Parceiro parceiroSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o Parceiro: [{parceiroSelecionado.Nome}] ?", "Exclusão de Parceiros", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                controlador.Excluir(id);
                List<Parceiro> funcionarios = controlador.SelecionarTodos();
                tabela.AtualizarRegistros(funcionarios);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Parceiro: [{parceiroSelecionado.Nome}] removido com sucesso");
            }
        }
        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }
        public UserControl ObterTabela()
        {
            List<Parceiro> funcionarios = controlador.SelecionarTodos();
            tabela.AtualizarRegistros(funcionarios);
            return tabela;
        }
    }
}
