using MauiCustoViagem.Models;

namespace MauiCustoViagem
{
    public partial class MainPage : ContentPage
    {

         
        public static Viagem vl = new Viagem();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            vl.Destino = txt_destino.Text;
            vl.Origem = txt_origem.Text;
            vl.Distancia = Convert.ToDouble(txt_distancia.Text);
            vl.Rendimento = Convert.ToDouble(txt_rendimento.Text);
            vl.Preco_combust = Convert.ToDouble(txt_combustivel.Text);
            await Navigation.PushAsync(new Views.CalcularViagem());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Add_Pedagio());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Lista_Pedagio());
        }
    }

}
