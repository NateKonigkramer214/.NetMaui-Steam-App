
using SteamInfomation.MVVM.Models;
using Newtonsoft.Json;
using SteamInfomation.MVVM.ViewModels;

namespace SteamInfomation.MVVM.MainViews;

public partial class AccountInformation : ContentPage
{
	public AccountInformation()
	{
		InitializeComponent();
        BindingContext = new AccountInformationViewModel();
    }
}