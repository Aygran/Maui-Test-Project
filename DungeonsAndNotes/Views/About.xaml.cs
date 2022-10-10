namespace DungeonsAndNotes.Views;

public partial class About : ContentPage
{
	public About()
	{
		InitializeComponent();
	}

	private async void LearnMore_Clicked(object sender, EventArgs e)
	{
		if (BindingContext is Models.About about)
		{
            await Launcher.Default.OpenAsync("https://aka.ms/maui");
        }
	}
}