using SteamInfomation.MVVM.Models;
using Newtonsoft.Json;
using SteamInfomation.MVVM.ViewModels;

namespace SteamInfomation.MVVM.MainViews;

public partial class Achievements : ContentPage
{
	public Achievements()
	{
		InitializeComponent();
		BindingContext = new AchievementsViewModel();	
	}
}