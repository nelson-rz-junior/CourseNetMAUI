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
		ctrlListView.ItemsSource = MovieList.GetGroupList();
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

    private async void ctrlListView_Refreshing(object sender, EventArgs e)
    {
        ctrlListView.IsRefreshing = true;

        await Task.Delay(2000);

        List<GroupMovie> movies = MovieList.GetGroupList();
        var disneyGroup = movies.FirstOrDefault(x => x.CompanyName == "Disney");

        Movie newMovie = new()
        {
            Id = 99,
            Name = "Novo Filme acionado pelo refresh",
            Description = "Este filme somente é adicionado à lista inicial quando o refresh do ListView é acionado manualmente. Para recarregar a lista inicial, basta clicar no botão 'Carregar Filmes'.",
            LaunchYear = 2025,
            Duration = new TimeSpan(0, 10, 0)
        };

        disneyGroup.Insert(0, newMovie);

        ctrlListView.ItemsSource = movies;

        ctrlListView.IsRefreshing = false;
    }
}