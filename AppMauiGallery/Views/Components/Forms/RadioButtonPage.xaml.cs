namespace AppMauiGallery.Pages.Forms;

public partial class RadioButtonPage : ContentPage
{
	public RadioButtonPage()
	{
		InitializeComponent();
	}

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if (e.Value)
		{
			var radioButton = (RadioButton)sender;
			DisplayAlert("Checked Changed", $"You selected {radioButton.Content}", "OK");
        }
    }
}