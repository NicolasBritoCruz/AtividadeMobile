namespace AtividadeMobile;
using AtividadeMobile.Models;

public partial class PopupEditar : ContentPage
{

    public Cadastro UsuarioAtual;
	public PopupEditar(Cadastro usuarioAtual)
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        UsuarioAtual = usuarioAtual;

    }

    private async void btnOk2_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PaginaConta(UsuarioAtual));
    }
}