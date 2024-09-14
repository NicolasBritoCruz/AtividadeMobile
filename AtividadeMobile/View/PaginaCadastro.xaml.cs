namespace AtividadeMobile;
using AtividadeMobile.Services;
using AtividadeMobile.Models;

public partial class PaginaCadastro : ContentPage
{

    private CadastroServices _cadastroServices;
    public PaginaCadastro()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        _cadastroServices = new CadastroServices();
    }

    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaInicial());
    }

    private async void btnCadastrar_Clicked(object sender, EventArgs e)
    {

        string nome = txtNome.Text;
        string sobrenome = txtSobrenome.Text;
        string email = txtEmail.Text;
        string senha = txtSenha.Text;

        if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(sobrenome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
        {
            txtErro.IsVisible = true;
            txtErro.Text = "Erro: Preencha todos os campos!";
            return;

        }

        //VERIFICAR FORMATO EMAIL
        if (!email.Contains("@") || !email.Contains("."))
        {
            txtErro.IsVisible = true;
            txtErro.Text = "Erro: Email inválido!";
            return;
        }

        Cadastro cadastro = new Cadastro
        {
            Nome = nome,
            Sobrenome = sobrenome,
            Email = email,
            Senha = senha
        };

        if (_cadastroServices.Cadastrar(cadastro))
        {
            await Navigation.PushAsync(new PaginaInicial());

        }
        else
        {
            txtErro.IsVisible = true;
            txtErro.Text = "Email já cadastrado";
            return;
        }

    }
}