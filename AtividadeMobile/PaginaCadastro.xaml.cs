namespace AtividadeMobile;

public partial class PaginaCadastro : ContentPage
{
    public PaginaCadastro()
    {
        InitializeComponent();
    }

    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaInicial());
    }
}