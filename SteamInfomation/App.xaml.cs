using SteamInfomation.MVVM.MainViews;


namespace SteamInfomation;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new SteamAppMainPage();
	}
}
