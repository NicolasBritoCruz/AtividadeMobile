namespace AtividadeMobile;

public partial class PopupCadastro : ContentPage
{
	public PopupCadastro()
	{
		InitializeComponent();
	}

    private async void btnSim_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PaginaInicial());
    }

    private async void btnNao_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaConta());
    }
}