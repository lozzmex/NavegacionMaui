namespace NavegacionMaui.Views;

public partial class InicioPage : ContentPage
{
	public InicioPage()
	{
		//Crea los controles que escribimos en el xaml.
		InitializeComponent();
	}

	private async void OnVerInformacionClicked(object sender, EventArgs e)
	{
		// Abre la Pagina asociada a la ruta
		await Shell.Current.GoToAsync("Informacion");
	}
}