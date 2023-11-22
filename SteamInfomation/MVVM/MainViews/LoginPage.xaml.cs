namespace SteamInfomation.MVVM.MainViews;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void LoginBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainSteamPage());
    }

    private void CreateACBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CreateAccountPage());
    }
}