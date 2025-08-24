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
        lblValue.Text = $"Voc� pesquisou por: {searchBar.Text}";
    }
}