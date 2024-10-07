namespace Game.Oynalar;

public partial class gamePage4 : ContentPage
{
	public gamePage4()
	{
		InitializeComponent();
	}

    private async void tugatish_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}