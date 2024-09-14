namespace AtividadeMobile;

public partial class PopupEditar : ContentPage
{
	public PopupEditar()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void btnOk2_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PaginaConta());
    }
}