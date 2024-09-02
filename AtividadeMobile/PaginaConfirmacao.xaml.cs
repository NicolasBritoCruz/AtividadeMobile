namespace AtividadeMobile;

public partial class PaginaConfirmacao : ContentPage
{
	public PaginaConfirmacao()
	{
		InitializeComponent();
	}

    private async void btnSairConfirmacao_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PaginaInicial());
    }
}