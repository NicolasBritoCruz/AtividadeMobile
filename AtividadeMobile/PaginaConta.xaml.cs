namespace AtividadeMobile;

public partial class PaginaConta : ContentPage
{
    public PaginaConta()
    {
        InitializeComponent();
    }
    private async void btnSair2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaEntrar());
    } 

    private async void btnEditar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PaginaEditar());
    }

    private async void btnExcluir_Clicked(object sender, EventArgs e)
    {
        {
            await Navigation.PushAsync(new PopupCadastro());  
        }
    }
}