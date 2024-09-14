namespace AtividadeMobile;

public partial class PaginaEntrar : ContentPage
{
	public PaginaEntrar()
	{
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }
    private async void btnSair_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PaginaInicial());
    }

    private async void btnUsuarios_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaUsuarios());
    }
    private async void btnConta_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaConta());
    }

}