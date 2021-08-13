using System.Windows.Forms;

namespace LocadoraDeVeiculos.WindowsApp.Shared
{
    public interface ICadastravel
    {
        void InserirNovoRegistro();
        void EditarRegistro();
        void ExcluirRegistro();
        UserControl ObterTabela();
        void FiltrarRegistros();
        void AgruparRegistros();
    }
}
