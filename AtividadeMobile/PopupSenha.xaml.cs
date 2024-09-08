namespace AtividadeMobile;

public partial class PopupSenha : ContentPage
{
	public PopupSenha()
	{
		InitializeComponent();
	}

    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PaginaInicial());
    }
}