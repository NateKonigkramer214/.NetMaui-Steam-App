using SteamInfomation.MVVM.ViewModels;

namespace SteamInfomation.MVVM.MainViews;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		BindingContext = new LoginViewModel();
	}
}