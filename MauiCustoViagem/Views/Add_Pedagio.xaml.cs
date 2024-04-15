using MauiCustoViagem.Models;

namespace MauiCustoViagem.Views;

public partial class Add_Pedagio : ContentPage
{
	public Add_Pedagio()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		try
		{

			Pedagio p = new Pedagio
			{
				Local = txt_local.Text,
				Valor = Convert.ToDouble(txt_Valor.Text)
			};

			await App.Db.Insert(p);
            await DisplayAlert("Sucesso!", "Produto Inserido", "OK");

        } catch (Exception ex)
		{
			await DisplayAlert("Ops!", ex.Message, "OK");
		}
    }
}