namespace SteamInfomation.MVVM.MainViews;

public partial class MainSteamPage : ContentPage
{
	public MainSteamPage()
	{
		InitializeComponent();
	}

    private void img1_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SteamAppMainPage());
    }

    private void img2_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SteamAppMainPage());

    }
}