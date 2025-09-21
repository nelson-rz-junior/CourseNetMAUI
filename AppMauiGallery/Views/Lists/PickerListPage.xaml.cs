using AppMauiGallery.Views.Lists.Models;

namespace AppMauiGallery.Views.Lists;

public partial class PickerListPage : ContentPage
{
	public PickerListPage()
	{
		InitializeComponent();
	}

    private void CarregarFilmes_Clicked(object sender, EventArgs e)
    {
		PickerList.ItemsSource = MovieList.GetList();
        PickerList.ItemDisplayBinding = new Binding("Name");
        btnCarregarFilmes.IsEnabled = false;
    }

    private void LimparSelecao_Clicked(object sender, EventArgs e)
    {
        PickerList.SelectedItem = null;
    }

    private void PickerList_SelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        Movie movie = picker.SelectedItem as Movie;

        if (movie != null)
        {
            DisplayAlert("Filme selecionado", $"[ {movie.Id} ]: {movie.Name} ({movie.LaunchYear})", "OK");
        }
    }
}