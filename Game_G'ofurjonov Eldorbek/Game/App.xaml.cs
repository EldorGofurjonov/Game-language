using Game.Oynalar;
namespace Game
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //var navigatsiya = new NavigationPage(new NavContentPage1());
            //navigatsiya.BarBackgroundColor = Colors.Firebrick;
            //navigatsiya.BarTextColor = Colors.Black;
            //MainPage = navigatsiya;

            var obj = new NavigationPage(new gamePage1());
            MainPage = obj;
        }
    }
}
