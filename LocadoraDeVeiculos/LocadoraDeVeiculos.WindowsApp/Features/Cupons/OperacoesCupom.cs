using LocadoraDeVeiculos.Controladores.CupomModule;
using LocadoraDeVeiculos.Dominio.CupomModule;
using LocadoraDeVeiculos.WindowsApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Features.Cupons
{
    public class OperacoesCupom : ICadastravel
    {
        private CupomRepository controlador;
        private readonly TabelaCupomControl tabela;

        public OperacoesCupom(CupomRepository controladorCupom)
        {
            controlador = controladorCupom;
            tabela = new TabelaCupomControl();
        }

        public void InserirNovoRegistro()
        {
            TelaCupomForm tela = new TelaCupomForm("Cadastro de Cupom");

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.InserirNovo(tela.Cupom);

                List<Cupom> cupons = controlador.SelecionarTodos();

                tabela.AtualizarRegistros(cupons);

                TelaPrincipalForm.Instancia.AtualizarRodape($"Cupom: [{tela.Cupom.Nome}] inserido com sucesso");
            }
        }

        public void EditarRegistro()
        {
            int id = tabela.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Cupom para poder Editar!", "Edição de Cupons", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Cupom cupomSelecionado = controlador.SelecionarPorId(id);
            TelaCupomForm tela = new TelaCupomForm("Edição de Cupom");
            tela.Cupom = cupomSelecionado;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                controlador.Editar(id, tela.Cupom);
                List<Cupom> funcionarios = controlador.SelecionarTodos();
                tabela.AtualizarRegistros(funcionarios);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Cupom: [{cupomSelecionado.Nome}] editado com sucesso");
            }
        }

        public void ExcluirRegistro()
        {
            int id = tabela.ObtemIdSelecionado();

            if (id == 0)
            {
                MessageBox.Show("Selecione um Cupom para excluir", "Exclusão de Cupom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Cupom parceiroSelecionado = controlador.SelecionarPorId(id);

            if (MessageBox.Show($"Tem certeza que deseja excluir o cupom: [{parceiroSelecionado.Nome}] ?", "Exclusão de Cupons", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                controlador.Excluir(id);
                List<Cupom> cupons = controlador.SelecionarTodos();
                tabela.AtualizarRegistros(cupons);
                TelaPrincipalForm.Instancia.AtualizarRodape($"Cupom: [{parceiroSelecionado.Nome}] removido com sucesso");
            }
        }

        public UserControl ObterTabela()
        {
            List<Cupom> cupons = controlador.SelecionarTodos();
            tabela.AtualizarRegistros(cupons);
            return tabela;
        }

        public void FiltrarRegistros()
        {
            throw new NotImplementedException();
        }

        public void AgruparRegistros()
        {
            throw new NotImplementedException();
        }
    }
}
