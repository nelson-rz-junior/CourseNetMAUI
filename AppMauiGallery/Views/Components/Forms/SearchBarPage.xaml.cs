namespace AppMauiGallery.Pages.Forms;

public partial class SearchBarPage : ContentPage
{
	public SearchBarPage()
	{
		InitializeComponent();
	}

    private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
		var searchBar = (SearchBar)sender;
        lblValue.Text = $"Você pesquisou por: {searchBar.Text}";
    }
}