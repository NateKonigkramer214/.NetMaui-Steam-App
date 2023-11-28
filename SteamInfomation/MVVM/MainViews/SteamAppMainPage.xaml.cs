namespace SteamInfomation.MVVM.MainViews;

public partial class SteamAppMainPage : ContentPage
{
	public SteamAppMainPage()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked_2(object sender, EventArgs e)
    {
        AccountInformation accountInformation = new AccountInformation();
        Navigation.PushAsync(accountInformation);   
    }

    private void ImageButton_Clicked_3(object sender, EventArgs e)
    {
        Achievements achievements = new Achievements();
        Navigation.PushAsync(achievements);
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        Launcher.Default.OpenAsync("https://forms.gle/ge3gq1dReqeMhUp76");
    }
}