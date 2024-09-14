using AtividadeMobile.Models;
using AtividadeMobile.Services;

namespace AtividadeMobile;

public partial class PaginaEditar : ContentPage
{

    public Cadastro UsuarioAtual;
    public CadastroServices _cadastroServices;

    public PaginaEditar(Cadastro usuarioAtual)
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        UsuarioAtual = usuarioAtual;
        _cadastroServices = new CadastroServices();
    }

    private async void btnSair3_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PaginaConta(UsuarioAtual));
    }

    private async void btnConfirmar_Clicked(object sender, EventArgs e)
    {
        UsuarioAtual.Nome = txtNome.Text;
        UsuarioAtual.Sobrenome = txtSobrenome.Text;
        _cadastroServices.AtualizarCadastro(UsuarioAtual);
        await Navigation.PushAsync(new PopupEditar(UsuarioAtual));
    }
}