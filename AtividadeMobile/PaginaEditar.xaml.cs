namespace AtividadeMobile;

public partial class PaginaEditar : ContentPage
{
	public PaginaEditar()
	{
		InitializeComponent();
	}

    private async void btnSair3_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PaginaConta());
    }
}