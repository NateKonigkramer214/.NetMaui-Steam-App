using SteamInfomation.MVVM.ViewModels;

namespace SteamInfomation.MVVM.MainViews;

public partial class CreateAccountPage : ContentPage
{
	public CreateAccountPage()
	{
		InitializeComponent();
        BindingContext = new CreateAccountViewModel();
    }
}