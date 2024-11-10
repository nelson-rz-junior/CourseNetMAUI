namespace AppMauiGallery.Views.Components.General;

public partial class ImageButtonPage : ContentPage
{
	bool buttonState = false;

	public ImageButtonPage()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		buttonState = !buttonState;

		var imgButton = (ImageButton)sender;
		imgButton.Source = buttonState ? ImageSource.FromFile("poweron.png") : ImageSource.FromFile("poweroff.png");
    }
}