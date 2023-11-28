using SteamInfomation.MVVM.ViewModels;

namespace SteamInfomation.MVVM.MainViews;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		
	}

    private void CreateACBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RegisterPage());
    }

    private void LoginBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SteamAppMainPage());
    }


}