namespace AppMauiGallery.Pages.Forms;

public partial class SliderPage : ContentPage
{
	public SliderPage()
	{
		InitializeComponent();
	}

    private void Slider_DragStarted(object sender, EventArgs e)
    {
        lblStatus.Text = "Arrastando...";
    }

    private void Slider_DragCompleted(object sender, EventArgs e)
    {
        lblStatus.Text = "Pronto!";
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        lblValue.Text = $"Valor: {e.NewValue:N2}";
    }
}