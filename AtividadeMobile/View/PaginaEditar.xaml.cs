namespace AtividadeMobile;

public partial class PaginaEditar : ContentPage
{
	public PaginaEditar()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void btnSair3_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PaginaConta());
    }

    private async void btnConfirmar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PopupEditar());
    }
}