namespace AtividadeMobile;
using AtividadeMobile.Models;

public partial class PaginaEntrar : ContentPage
{

    public Cadastro UsuarioAtual;
    public PaginaEntrar(Cadastro usuarioAtual)
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        UsuarioAtual = usuarioAtual;

    }
    private async void btnSair_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaInicial());
    }

    private async void btnUsuarios_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaUsuarios(UsuarioAtual));
    }
    private async void btnConta_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaConta(UsuarioAtual));
    }

}