using SteamInfomation.MVVM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SteamInfomation.MVVM.Models;
using System.Windows.Input;

internal partial class AchievementsViewModel : ObservableObject
{
    private readonly SteamApiService _teamApiService;
    public AchievementsViewModel()
    {
        _teamApiService = new SteamApiService();
    }

    [ObservableProperty]
    private string steamid;
    [ObservableProperty]
    private string appid;
    [ObservableProperty]
    private string gamename;
    [ObservableProperty]
    private string achievements;
    [ObservableProperty]
    private string achieved;
    [ObservableProperty]
    private string unlocktime;


    [RelayCommand]
    public async Task FetchAchievementsData()
    {
        var steamPlayer = await _teamApiService.GetAccountInformation();

        if (steamPlayer != null && steamPlayer.response != null && steamPlayer.response.players.Length > 0)
        {
            
        }
    }
}
