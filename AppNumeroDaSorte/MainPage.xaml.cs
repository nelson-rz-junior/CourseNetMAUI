namespace AppNumeroDaSorte;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnGenerateLuckNumbers(object sender, EventArgs e)
	{
		AppName.IsVisible = false;
		ContainerLuckNumbers.IsVisible = true;

		var set = GenerateLuckNumbers();
		LuckNumber01.Text = set.ElementAt(0).ToString("D2");
        LuckNumber02.Text = set.ElementAt(1).ToString("D2");
        LuckNumber03.Text = set.ElementAt(2).ToString("D2");
        LuckNumber04.Text = set.ElementAt(3).ToString("D2");
        LuckNumber05.Text = set.ElementAt(4).ToString("D2");
        LuckNumber06.Text = set.ElementAt(5).ToString("D2");
    }

	private SortedSet<int> GenerateLuckNumbers()
	{
		var result = new SortedSet<int>();

        while (result.Count < 6)
        {
			var rng = new Random();
			result.Add(rng.Next(1, 61));
        }

        return result;
	}
}