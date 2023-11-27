namespace SteamInfomation.MVVM.MainViews;

public partial class Achievements : ContentPage
{
	public Achievements()
	{
		InitializeComponent();
		BindingContext = new AchievementsViewModel();
	}
}