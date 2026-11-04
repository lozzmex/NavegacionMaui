using NavegacionMaui.Views;
namespace NavegacionMaui;
public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        // Asociamos un nombre de ruta con una clase de página.
        Routing.RegisterRoute(
        "Informacion", typeof(InformacionPage));
    }
}