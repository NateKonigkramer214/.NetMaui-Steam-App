using SteamInfomation.MVVM.MainViews;
using Microsoft.Maui.Controls;


namespace SteamInfomation;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new SteamAppMainPage());
        
    }
}
