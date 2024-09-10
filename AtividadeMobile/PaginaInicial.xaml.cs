namespace AtividadeMobile;

public partial class PaginaInicial : ContentPage
{
	public PaginaInicial()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void btnEntrar_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PaginaEntrar());
    }

    private async void btnCadastro_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaCadastro());
    }

    private async void btnEsquecer_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PopupSenha());
    }
}