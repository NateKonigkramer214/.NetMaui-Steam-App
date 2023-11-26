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
using System.Collections.ObjectModel;

namespace SteamInfomation.MVVM.ViewModels
{
    internal partial class SearchGamesViewModel : ObservableObject
    {
        private readonly SteamApiService _teamApiService;
        
        public SearchGamesViewModel()
        {
            _teamApiService = new SteamApiService();
        }

        [ObservableProperty]
        private string steamid;
        [ObservableProperty]
        private string img_icon_url;
        [ObservableProperty]
        private string name;
        [ObservableProperty]
        private int playtime_2weeks;
        [ObservableProperty]
        private int playtime_forever;
        [ObservableProperty]
        private SteamApiResponse.Game[] games;
        [ObservableProperty]
        private int total_count;


        [RelayCommand]

        public async Task FetchRecentGames()
        {
            var steamGame = await _teamApiService.GetRecentGames(Steamid);

            if (steamGame != null && steamGame.response != null && steamGame.response.games.Length > 0)
            {
                Img_icon_url = steamGame.response.games[0].img_icon_url;
                Name = steamGame.response.games[0].name;
                Playtime_2weeks = steamGame.response.games[0].playtime_2weeks;
                Playtime_forever = steamGame.response.games[0].playtime_forever;
                Games = steamGame.response.games;
                


            }
        }
    }
}
