namespace AppMauiGallery.Pages.Forms;

public partial class DatePickerPage : ContentPage
{
	public DatePickerPage()
	{
		InitializeComponent();
	}

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
		lblValue.Text = $"Data selecionada: {e.NewDate.ToString("dd/MM/yyyy")}";
    }
}