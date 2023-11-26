using SteamInfomation.MVVM.ViewModels;

namespace SteamInfomation.MVVM.MainViews;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
        BindingContext = new LoginViewModel();
    }

    private void LoginBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SteamAppMainPage());
    }

    private void CreateACBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CreateAccountPage());
    }
}