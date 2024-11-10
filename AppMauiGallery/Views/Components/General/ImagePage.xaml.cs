namespace AppMauiGallery.Views.Components.General;

public partial class ImagePage : ContentPage
{
	public ImagePage()
	{
		InitializeComponent();

		imgBot.Source = ImageSource.FromFile("dotnet_bot.png");
		imgAnimation.Source = ImageSource.FromUri(new Uri("https://gifmania.com.br/wp-content/uploads/2020/01/BOM_DIA.gif"));
    }
}