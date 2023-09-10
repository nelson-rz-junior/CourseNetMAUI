namespace AppNavigationPage;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
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