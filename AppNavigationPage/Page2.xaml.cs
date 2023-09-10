namespace AppNavigationPage;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private void ButtonNext_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Page3());
    }

    private void ButtonBack_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    protected override bool OnBackButtonPressed()
    {
        return true;
    }
}