
using SteamInfomation.MVVM.ViewModels;

namespace SteamInfomation.MVVM.MainViews;
public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
		BindingContext = new RegisterViewModel();
	}
}