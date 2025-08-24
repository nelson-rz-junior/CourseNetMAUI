namespace AppMauiGallery.Pages.Forms;

public partial class SwitchPage : ContentPage
{
	public SwitchPage()
	{
		InitializeComponent();
	}

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
		lblStatus.Text = e.Value ? "Ativado" : "Desativado";
    }
}