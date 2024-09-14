namespace AtividadeMobile;
using AtividadeMobile.Models;
using AtividadeMobile.Services; 

public partial class PaginaConta : ContentPage
{

    public Cadastro UsuarioAtual;
    public CadastroServices _cadastroServices;

    public PaginaConta(Cadastro usuarioAtual)
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        UsuarioAtual = usuarioAtual;
        _cadastroServices = new CadastroServices();

    }
    private async void btnSair2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaEntrar(UsuarioAtual));
    }

    private async void btnEditar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaEditar(UsuarioAtual));
    }

    private async void btnExcluir_Clicked(object sender, EventArgs e)
    {
        {
            _cadastroServices.DeletarCadastro(UsuarioAtual);
            await Navigation.PushAsync(new PopupCadastro());
        }
    }
}