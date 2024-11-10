namespace AppMauiGallery.Views.Components.General;

public partial class ButtonPage : ContentPage
{
	public ButtonPage()
	{
		InitializeComponent();
	}

    private void Button_Pressed(object sender, EventArgs e)
    {
        lblLog.Text += $"Button_Pressed: {DateTime.Now}\n";
    }

    private void Button_Released(object sender, EventArgs e)
    {
        lblLog.Text += $"Button_Released: {DateTime.Now}\n";
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        lblLog.Text += $"Button_Clicked: {DateTime.Now}\n";
    }

    private void ClearButton_Clicked(object sender, EventArgs e)
    {
        lblLog.Text = string.Empty;
    }
}