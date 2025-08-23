namespace AppMauiGallery.Pages.Forms;

public partial class StepperPage : ContentPage
{
	public StepperPage()
	{
		InitializeComponent();
	}

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		lblValue.Text = $"Antigo: {e.OldValue:N0} | Novo: {e.NewValue:N0}";
    }
}