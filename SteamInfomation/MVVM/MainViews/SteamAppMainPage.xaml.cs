namespace SteamInfomation.MVVM.MainViews;

public partial class SteamAppMainPage : ContentPage
{
	public SteamAppMainPage()
	{
		InitializeComponent();
	}

    //This was button for linking pages
    private void BtnLogin_Clicked(object sender, EventArgs e)
    {
		//Navigation.PushAsync(new LoginPage());
    }

    private void searchBar_SearchButtonPressed(object sender, EventArgs e)
    {

    }
}