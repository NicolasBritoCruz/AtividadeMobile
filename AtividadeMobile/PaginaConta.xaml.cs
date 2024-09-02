namespace AtividadeMobile;

public partial class PaginaConta : ContentPage
{
    public PaginaConta()
    {
        InitializeComponent();
    }
    private void btnSair2_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private async void btnExcluir_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaConfirmacao());
    }
}