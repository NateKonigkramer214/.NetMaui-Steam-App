
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

	private void profileButton_Clicked(object sender, EventArgs e)
	{

	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        // Get SteamID entered by the user
        string steamId = steamIdEntry.Text;

        // Make API request based on the entered SteamID
        AccountInfo.Rootobject userData = await GetUserDataAsync(steamId);

        // Update the UI with the fetched data
        if (userData != null)
        {
            BindingContext = userData.response.players[0];
        }
        else
        {
            // Handle error or notify the user
        }
    }

    private async Task<AccountInfo.Rootobject> GetUserDataAsync(string steamId)
    {
        using (HttpClient httpClient = new HttpClient())
        {
            try
            {
                string apiUrl = $"http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key=117134DA22288BA65A00782B19A6CD95&steamids={steamId}";
                string response = await httpClient.GetStringAsync(apiUrl);
                return JsonConvert.DeserializeObject<AccountInfo.Rootobject>(response);
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., network error)
                return null;
            }
        }
    }
}