namespace MauiCustoViagem.Views;
using MauiCustoViagem.Models;
using System.Collections.ObjectModel;

public partial class Lista_Pedagio : ContentPage
{

    ObservableCollection<Pedagio> lista_pedagio = new ObservableCollection<Pedagio>();

    public Lista_Pedagio()
	{
		InitializeComponent();
        lst_pedagios.ItemsSource = lista_pedagio;
    }
    protected async override void OnAppearing()
    {
        if (lista_pedagio.Count == 0)
        {

            List<Pedagio> tap = await App.Db.GetAll();
            foreach (Pedagio p in tap)
            {
                lista_pedagio.Add(p);
            }

        }

    }

}