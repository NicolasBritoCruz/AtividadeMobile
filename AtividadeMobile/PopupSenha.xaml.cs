namespace AtividadeMobile;

public partial class PopupSenha : ContentPage
{
	public PopupSenha()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PaginaInicial());
    }
}