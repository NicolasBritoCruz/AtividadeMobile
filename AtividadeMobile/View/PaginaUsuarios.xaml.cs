namespace AtividadeMobile;

public partial class PaginaUsuarios : ContentPage
{
	public PaginaUsuarios()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void btnSairUsuarios_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PaginaEntrar());	
    }
}