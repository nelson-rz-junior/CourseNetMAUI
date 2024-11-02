using AppMauiGallery.Repositories;

namespace AppMauiGallery.Pages;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
        InitializaMenuComponent();
	}

	private void InitializaMenuComponent()
	{
        var categories = new CategoryRepository().GetCategories();

		foreach (var category in categories)
		{
            var lblCategory = new Label
            {
                Text = category.Name,
                FontFamily = "OpenSansSemibold"
            };

			MenuContainer.Children.Add(lblCategory);

            foreach (var component in category.Components)
			{
                var tap = new TapGestureRecognizer
                {
                    CommandParameter = component.Page
                };

                tap.Tapped += OnTapComponent;

                var lblComponentTitle = new Label
                {
                    Text = component.Title,
                    FontFamily = "OpenSansSemibold",
                    Margin = new Thickness(20, 20, 0, 0)
                };

                lblComponentTitle.GestureRecognizers.Add(tap);

                var lblComponentDescription = new Label
                {
                    Text = component.Description,
                    Margin = new Thickness(20, 0, 0, 0)
                };

                lblComponentDescription.GestureRecognizers.Add(tap);

                MenuContainer.Children.Add(lblComponentTitle);
				MenuContainer.Children.Add(lblComponentDescription);
			}
		}
    }

    private void OnTapComponent(object sender, TappedEventArgs e)
    {
        var label = (Label)sender;
        var tap = (TapGestureRecognizer)label.GestureRecognizers[0];
        var page = (Type)tap.CommandParameter;

        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage((Page)Activator.CreateInstance(page));
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }

    private void OnTapInicio(object sender, TappedEventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new MainPage());
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }
}