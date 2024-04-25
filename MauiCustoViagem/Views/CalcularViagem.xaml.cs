using MauiCustoViagem.Models;

namespace MauiCustoViagem.Views;

public partial class CalcularViagem : ContentPage
{

	public CalcularViagem()
	{
		InitializeComponent();
	}

    private async Task Button_Clicked(object sender, EventArgs e)
    {
        
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        List<Pedagio> pedagios = await App.Db.GetAll();
        foreach (Pedagio p in pedagios)
        {
            await App.Db.Delete(p.Id);
        }

        MainPage.vl.Distancia = -1;
        MainPage.vl.Rendimento = -1;
        MainPage.vl.Origem = " "; 
        MainPage.vl.Preco_combust = -1;
        MainPage.vl.Destino = " ";

        await Navigation.PushAsync(new MainPage());

    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
double consumo_Carro = ((MainPage.vl.Distancia / MainPage.vl.Rendimento) * MainPage.vl.Preco_combust);
        double valor_pedagio = 0;
        double total = 0;


        List<Pedagio> pedagios = await App.Db.GetAll();
        foreach (Pedagio p in pedagios)
        {
            valor_pedagio += p.Valor;
        }

        total = consumo_Carro + valor_pedagio;
        await DisplayAlert("Soma total:", $"Pedagio: {valor_pedagio.ToString("C")}\nConsumo: {consumo_Carro.ToString("C")}\n---------\nTotal: {total.ToString("C")}", "Ok");
        lbl_valor.Text = "Valor: " + total.ToString("C");
        lbl_valor.IsVisible = true;

        lbl_origem.Text = MainPage.vl.Origem;
        lbl_destino.Text = MainPage.vl.Destino;
        lbl_valor.Text = total.ToString("C");
    }
}