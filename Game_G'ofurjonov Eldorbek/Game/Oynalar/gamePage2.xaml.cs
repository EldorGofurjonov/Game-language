namespace Game.Oynalar;

public partial class gamePage2 : ContentPage
{
   public string engl, uzbk;
	public gamePage2(string eng,string uzb)
	{
		InitializeComponent();
        engl= eng;
        uzbk= uzb;
       
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var obj= new gamePage3(engl,uzbk);
        await Navigation.PushAsync(obj);
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new gamePage3(uzbk,engl));
    }
}