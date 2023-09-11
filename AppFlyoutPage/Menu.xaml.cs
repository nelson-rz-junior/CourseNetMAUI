namespace AppFlyoutPage;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

	protected void OnButtonClickedPage1(object sender, EventArgs e)
	{
		((FlyoutPage)Application.Current.MainPage).Detail = new NavigationPage(new Page1());
	}

    protected void OnButtonClickedPage2(object sender, EventArgs e)
    {
		((FlyoutPage)Application.Current.MainPage).Detail = new NavigationPage(new Page2());
    }

    protected void OnButtonClickedPage3(object sender, EventArgs e)
    {
        ((FlyoutPage)Application.Current.MainPage).Detail = new NavigationPage(new Page3());
    }
}