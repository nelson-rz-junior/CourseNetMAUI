using AppMauiGallery.Views.Lists.Models;

namespace AppMauiGallery.Views.Lists;

public partial class ListViewPage : ContentPage
{
	public ListViewPage()
	{
		InitializeComponent();
	}

    private void btnCarregarFilmes_Clicked(object sender, EventArgs e)
    {
		ctrlListView.ItemsSource = MovieList.GetList();
        btnCarregarFilmes.IsEnabled = false;
    }

    private void ctrlListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var movie = e.SelectedItem as Movie;
        if (movie is not null)
        {
            DisplayAlert("Filme Selecionado", $"Você selecionou o filme: {movie.Name}", "OK");
            ctrlListView.SelectedItem = null;
        }
    }
}