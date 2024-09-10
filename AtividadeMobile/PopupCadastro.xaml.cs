namespace AtividadeMobile;

public partial class PopupCadastro : ContentPage
{
	public PopupCadastro()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void btnOk_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PaginaInicial());
    }
}