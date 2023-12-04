

namespace SteamInfomation.MVVM.MainViews;

public partial class SteamAppMainPage : ContentPage
{
    private Action<object> navigationAction;

    public ILauncher Launcher { get; set; }

    public SteamAppMainPage()
	{
		InitializeComponent();
    }

    public SteamAppMainPage(Action<object> navigationAction)
    {
        this.navigationAction = navigationAction;
    }

    public void ImageButton_Clicked_2(object sender, EventArgs e)
    {
        AccountInformation accountInformation = new AccountInformation();
        Navigation.PushAsync(accountInformation);   
    }

    public void ImageButton_Clicked_3(object sender, EventArgs e)
    {
        Achievements achievements = new Achievements();
        Navigation.PushAsync(achievements);
    }

    public void ImageButton_Clicked(object sender, EventArgs e)
    {
        Launcher.OpenAsync(new Uri("https://forms.gle/ge3gq1dReqeMhUp76"));
    }
}