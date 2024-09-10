namespace AtividadeMobile;

public partial class PaginaCadastro : ContentPage
{
    public PaginaCadastro()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaInicial());
    }

    private async void btnCadastrar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaInicial());
    }
}