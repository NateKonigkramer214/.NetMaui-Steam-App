
using SteamInfomation.MVVM.ViewModels;

namespace SteamInfomation.MVVM.MainViews;
public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
		BindingContext = new RegisterViewModel();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new LoginPage());
    }
}