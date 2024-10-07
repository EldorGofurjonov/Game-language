

namespace Game.Oynalar;

public partial class gamePage1 : ContentPage
{
	public gamePage1()
	{
		InitializeComponent();
	}
    private async void Button_Clicked(object sender, EventArgs e)
    {
		string eng;
		eng = box1.Text+"|";
		eng += box3.Text+"|";
		eng += box5.Text+"|";
		eng += box7.Text+"|";
		eng += box9.Text+"|";
		eng += box11.Text+"|";
		eng += box13.Text+"|";
		eng += box15.Text+"|";
		eng += box17.Text+"|";
		eng += box19.Text+"|";
		eng += box21.Text+"|";
		eng += box23.Text+"|";
		eng += box25.Text+"|";
		eng += box27.Text+"|";
		eng += box29.Text+"|";
		eng += box31.Text + "|";
		eng += box33.Text+"|";
		eng += box35.Text+"|";
		eng += box37.Text + "|";
		eng += box39.Text;

        string uzb;
		uzb = box2.Text + "|";
        uzb += box4.Text+"|";
        uzb += box6.Text+"|";
        uzb += box8.Text+"|";
        uzb += box10.Text+"|";
        uzb += box12.Text+"|";
        uzb += box14.Text+"|";
        uzb += box16.Text+"|";
        uzb += box18.Text+"|";
        uzb += box20.Text+"|";
        uzb += box22.Text+"|";
        uzb += box24.Text+"|";
        uzb += box26.Text+"|";
        uzb += box28.Text+"|";
        uzb += box30.Text+"|";
		uzb += box32.Text + "|";
		uzb += box34.Text + "|";
		uzb += box36.Text + "|";
		uzb += box38.Text + "|";
		uzb += box40.Text;

        var obj = new gamePage2(eng,uzb);
		await Navigation.PushAsync(obj);
    }

    private  void Button_Clicked_1(object sender, EventArgs e)
    {
		App.Current?.Quit();
    }
}