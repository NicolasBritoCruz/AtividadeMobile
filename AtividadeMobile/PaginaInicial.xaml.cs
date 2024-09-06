namespace AtividadeMobile;

public partial class PaginaInicial : ContentPage
{
	public PaginaInicial()
	{
		InitializeComponent();
	}

    private async void btnEntrar_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PaginaEntrar());
    }

    private async void btnCadastro_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaCadastro());
    }

    private void btnEsquecer_Clicked(object sender, EventArgs e)
    {

    }
}