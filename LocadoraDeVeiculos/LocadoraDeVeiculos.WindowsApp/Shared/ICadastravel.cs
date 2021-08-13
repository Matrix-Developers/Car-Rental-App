using System.Windows.Forms;

namespace eAgenda.WindowsApp.Shared
{
    public interface ICadastravel
    {
        void InserirNovoRegistro();

        void EditarRegistro();

        void ExcluirRegistro();

        UserControl ObterTabela();

        void FiltrarRegistros();
    }
}
