namespace AtividadeMobile;
using AtividadeMobile.Services;

public partial class PaginaInicial : ContentPage
{

    public CadastroServices _cadastroServices;

    public PaginaInicial()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        _cadastroServices = new CadastroServices();
    }

    private async void btnEntrar_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSenha.Text))
        {
            txtErro.IsVisible = true;
            txtErro.Text = "Erro: Preencha todos os campos!";
            return;
        }
        string email = txtEmail.Text;
        string senha = txtSenha.Text;

        var cadastro = _cadastroServices.Login(email, senha);

        if (cadastro != null)
        {
            await Navigation.PushAsync(new PaginaEntrar(cadastro));
        }
        else
        {
            txtErro.IsVisible = true;
            txtErro.Text = "Erro: Email ou senha inválidos!";
        }
    }

    private async void btnCadastro_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaCadastro());
    }

    private async void btnEsquecer_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PopupSenha());
    }
}