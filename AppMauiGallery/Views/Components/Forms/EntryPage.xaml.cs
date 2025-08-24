namespace AppMauiGallery.Pages.Forms;

public partial class EntryPage : ContentPage
{
    public EntryPage()
    {
        InitializeComponent();
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        lblTextChanged.Text = string.IsNullOrEmpty(e.NewTextValue) ? string.Empty : $"Echo: {e.NewTextValue}";
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
        lblTextChanged.Text = "Done!";
    }
}