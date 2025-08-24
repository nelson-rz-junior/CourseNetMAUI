namespace AppMauiGallery.Pages.Forms;

public partial class PickerPage : ContentPage
{
	public PickerPage()
	{
		InitializeComponent();
	}

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
		var picker = (Picker)sender;
		var fruit = (string)picker.SelectedItem;
		lblValue.Text = $"Você selecionou: {fruit}";
    }
}