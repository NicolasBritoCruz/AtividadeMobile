namespace AtividadeMobile;

public partial class PaginaUsuarios : ContentPage
{
	public PaginaUsuarios()
	{
		InitializeComponent();
	}

    private async void btnSairUsuarios_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();	
    }
}