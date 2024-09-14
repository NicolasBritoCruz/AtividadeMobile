namespace AtividadeMobile;
using System;
using System.Collections.Generic;
using AtividadeMobile.Models;
using AtividadeMobile.Services;

public partial class PaginaUsuarios : ContentPage
{
    public Cadastro UsuarioAtual;
    private CadastroServices _cadastroServices = new CadastroServices();
    private List<Cadastro> _cadastros = new List<Cadastro>();
    public PaginaUsuarios(Cadastro usuarioAtual)
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
        _cadastros = _cadastroServices.ObterCadastros();
        ListagemUsuarios.ItemsSource = _cadastros;
        UsuarioAtual = usuarioAtual;

    }

    private async void btnSairUsuarios_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PaginaEntrar(UsuarioAtual));	
    }
}