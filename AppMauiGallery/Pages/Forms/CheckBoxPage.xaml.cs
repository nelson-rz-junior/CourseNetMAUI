namespace AppMauiGallery.Pages.Forms;

public partial class CheckBoxPage : ContentPage
{
	private readonly List<string> options = [];

	public CheckBoxPage()
	{
		InitializeComponent();
	}

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        CheckBox checkBox = (CheckBox)sender;
        HorizontalStackLayout layout = (HorizontalStackLayout)checkBox.Parent;
        Label label = (Label)layout.Children[1];

        if (e.Value)
		{
            options.Add($"Você selecionou: {label.Text}");
        }
		else
		{
            options.Add($"Você desmarcou: {label.Text}");
        }

        lblStatus.Text = string.Join("\r\n", options);
    }
}