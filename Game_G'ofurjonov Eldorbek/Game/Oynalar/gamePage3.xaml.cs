
using Microsoft.Maui.Animations;

using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Game.Oynalar;

public partial class gamePage3 : ContentPage
{
	public string[] english;
	public string[] uzbek;
    public string togriJavob="";
    public int j = 1;
    public int natija=0;
    public gamePage3(string eng,string uzb)
	{
		InitializeComponent();
		english = eng.Split('|');
		uzbek = uzb.Split('|');


        Random random = new Random();

        int i = new Random().Next(1, 5);
        switch (i)
        {
            case 1:
                Tugma1.Text = uzbek[j - 1];
            back11:
                Tugma2.Text = uzbek[random.Next(0, 20)];
                if (Tugma1.Text == Tugma2.Text)
                    goto back11;
                back22:
                Tugma3.Text = uzbek[random.Next(0, 20)];
                if (Tugma1.Text == Tugma3.Text || Tugma2.Text == Tugma3.Text)
                    goto back22;
                back33:
                Tugma4.Text = uzbek[random.Next(1, 20)];
                if (Tugma1.Text == Tugma4.Text || Tugma2.Text == Tugma4.Text || Tugma3.Text == Tugma4.Text)
                    goto back33;
                break;
            case 2:
                Tugma2.Text = uzbek[j - 1];
            back1:
                Tugma1.Text = uzbek[random.Next(0, 20)];
                if (Tugma1.Text == Tugma2.Text)
                    goto back1;
                back2:
                Tugma3.Text = uzbek[random.Next(0, 20)];
                if (Tugma1.Text == Tugma3.Text || Tugma2.Text == Tugma3.Text)
                    goto back2;
                back3:
                Tugma4.Text = uzbek[random.Next(1, 20)];
                if (Tugma1.Text == Tugma4.Text || Tugma2.Text == Tugma4.Text || Tugma3.Text == Tugma4.Text)
                    goto back3;
                break;
            case 3:
                Tugma3.Text = uzbek[j - 1];
            back14:
                Tugma2.Text = uzbek[random.Next(0, 20)];
                if (Tugma3.Text == Tugma2.Text)
                    goto back14;
                back24:
                Tugma1.Text = uzbek[random.Next(0, 20)];
                if (Tugma1.Text == Tugma3.Text || Tugma2.Text == Tugma1.Text)
                    goto back24;
                back34:
                Tugma4.Text = uzbek[random.Next(1, 20)];
                if (Tugma1.Text == Tugma4.Text || Tugma2.Text == Tugma4.Text || Tugma3.Text == Tugma4.Text)
                    goto back34;
                break;
            case 4:
                Tugma4.Text = uzbek[j - 1];
            back16:
                Tugma2.Text = uzbek[random.Next(0, 20)];
                if (Tugma4.Text == Tugma2.Text)
                    goto back16;
                back26:
                Tugma3.Text = uzbek[random.Next(0, 20)];
                if (Tugma4.Text == Tugma3.Text || Tugma2.Text == Tugma3.Text)
                    goto back26;
                back36:
                Tugma1.Text = uzbek[random.Next(1, 20)];
                if (Tugma1.Text == Tugma4.Text || Tugma2.Text == Tugma1.Text || Tugma3.Text == Tugma1.Text)
                    goto back36;
                break;
        }






        soni.Text = $"{j}/{english.Length}";
        savol.Text = english[j - 1];
        togriJavob = uzbek[j - 1];

    }
    
    
    private async void ran(int jj)
    {
        await Task.Delay(1000);
        Tugma1.Background = default;
        Tugma2.Background = default;
        Tugma3.Background = default;
        Tugma4.Background = default;
        
        if (jj < 21)
        {
            Random random = new Random();

            int i = new Random().Next(1, 5);
            switch (i)
            {
                case 1:
                    Tugma1.Text = uzbek[jj - 1];
                back11:
                    Tugma2.Text = uzbek[random.Next(0, 20)];
                    if (Tugma1.Text == Tugma2.Text)
                        goto back11;
                    back22:
                    Tugma3.Text = uzbek[random.Next(0, 20)];
                    if (Tugma1.Text == Tugma3.Text || Tugma2.Text == Tugma3.Text)
                        goto back22;
                    back33:
                    Tugma4.Text = uzbek[random.Next(1, 20)];
                    if (Tugma1.Text == Tugma4.Text || Tugma2.Text == Tugma4.Text || Tugma3.Text == Tugma4.Text)
                        goto back33;
                    break;
                case 2:
                    Tugma2.Text = uzbek[jj - 1];
                back1:
                    Tugma1.Text = uzbek[random.Next(0, 20)];
                    if (Tugma1.Text == Tugma2.Text)
                        goto back1;
                    back2:
                    Tugma3.Text = uzbek[random.Next(0, 20)];
                    if (Tugma1.Text == Tugma3.Text || Tugma2.Text == Tugma3.Text)
                        goto back2;
                    back3:
                    Tugma4.Text = uzbek[random.Next(1, 20)];
                    if (Tugma1.Text == Tugma4.Text || Tugma2.Text == Tugma4.Text || Tugma3.Text == Tugma4.Text)
                        goto back3;
                    break;
                case 3:
                    Tugma3.Text = uzbek[jj - 1];
                back14:
                    Tugma2.Text = uzbek[random.Next(0, 20)];
                    if (Tugma3.Text == Tugma2.Text)
                        goto back14;
                    back24:
                    Tugma1.Text = uzbek[random.Next(0, 20)];
                    if (Tugma1.Text == Tugma3.Text || Tugma2.Text == Tugma1.Text)
                        goto back24;
                    back34:
                    Tugma4.Text = uzbek[random.Next(1, 20)];
                    if (Tugma1.Text == Tugma4.Text || Tugma2.Text == Tugma4.Text || Tugma3.Text == Tugma4.Text)
                        goto back34;
                    break;
                case 4:
                    Tugma4.Text = uzbek[jj - 1];
                back16:
                    Tugma2.Text = uzbek[random.Next(0, 20)];
                    if (Tugma4.Text == Tugma2.Text)
                        goto back16;
                    back26:
                    Tugma3.Text = uzbek[random.Next(0, 20)];
                    if (Tugma4.Text == Tugma3.Text || Tugma2.Text == Tugma3.Text)
                        goto back26;
                    back36:
                    Tugma1.Text = uzbek[random.Next(1, 20)];
                    if (Tugma1.Text == Tugma4.Text || Tugma2.Text == Tugma1.Text || Tugma3.Text == Tugma1.Text)
                        goto back36;
                    break;
            }
           
            soni.Text = $"{jj}/{english.Length}";
            savol.Text = english[jj - 1];
            togriJavob = uzbek[jj - 1];
        }
        else
        {
            savol.Text = "Natijangiz " + natija + "/" + english.Length;
            savol.TextColor = Colors.MediumVioletRed;
            await Task.Delay(3000);
           await Navigation.PopAsync();
        }
    }

    private void Tugma1_Clicked(object sender, EventArgs e)
    {
        if (Tugma1.Text == togriJavob)
        {
            Tugma1.Background = Colors.Green;
            natija++;
        }
        else
        {
            Tugma1.Background = Colors.Red;
            if (Tugma2.Text == togriJavob)
                Tugma2.Background = Colors.Green;
            else if (Tugma3.Text == togriJavob)
                Tugma3.Background = Colors.Green;
            else
                Tugma4.Background = Colors.Green;
        }
        
        j++;
        
        ran(j);

    }
  
    private void Tugma2_Clicked(object sender, EventArgs e)
    {
        if (Tugma2.Text == togriJavob)
        {
            Tugma2.Background = Colors.Green;
            natija++;
        }
        else
        {
            Tugma2.Background = Colors.Red;
            if (Tugma1.Text == togriJavob)
                Tugma1.Background = Colors.Green;
            else if (Tugma3.Text == togriJavob)
                Tugma3.Background = Colors.Green;
            else
                Tugma4.Background = Colors.Green;
        }

        j++;

        ran(j);
    }

    private void Tugma3_Clicked(object sender, EventArgs e)
    {
        if (Tugma3.Text == togriJavob)
        {
            Tugma3.Background = Colors.Green;
            natija++;
        }
        else
        {
            Tugma3.Background = Colors.Red;
            if (Tugma1.Text == togriJavob)
                Tugma1.Background = Colors.Green;
            else if (Tugma2.Text == togriJavob)
                Tugma2.Background = Colors.Green;
            else
                Tugma4.Background = Colors.Green;
        }

        j++;

        ran(j);

    }

    private void Tugma4_Clicked(object sender, EventArgs e)
    {
        if (Tugma4.Text == togriJavob)
        {
            Tugma4.Background = Colors.Green;
            natija++;
        }
        else
        {
            Tugma4.Background = Colors.Red;
            if (Tugma2.Text == togriJavob)
                Tugma2.Background = Colors.Green;
            else if (Tugma3.Text == togriJavob)
                Tugma3.Background = Colors.Green;
            else
                Tugma1.Background = Colors.Green;
        }

        j++;

        ran(j);

    }
    
}