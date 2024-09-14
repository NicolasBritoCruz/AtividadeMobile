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
        txtNomeLabel.Text = usuarioAtual.Nome;
        txtEmailLabel.Text = usuarioAtual.Email;
        txtNomeEntry.Placeholder = usuarioAtual.Nome;
        txtSobrenomeEntry.Placeholder = usuarioAtual.Sobrenome;
    }

    private async void btnSair3_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PaginaConta(UsuarioAtual));
    }

    private async void btnConfirmar_Clicked(object sender, EventArgs e)
    {

        string Nome = txtNomeEntry.Text;
        string Sobrenome = txtSobrenomeEntry.Text;
        if (string.IsNullOrEmpty(Nome) || string.IsNullOrEmpty(Sobrenome))
        {
            txtErro.Text = "Erro: Preencha todos os campos!";
            txtErro.IsVisible = true;
            return;
        }
        else
        {
            UsuarioAtual.Nome = Nome;
            UsuarioAtual.Sobrenome = Sobrenome;
            _cadastroServices.AtualizarCadastro(UsuarioAtual);
            await Navigation.PushAsync(new PopupEditar(UsuarioAtual));
        }
    }
}