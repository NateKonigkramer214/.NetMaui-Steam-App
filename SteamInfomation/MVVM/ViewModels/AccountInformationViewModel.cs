using SteamInfomation.MVVM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SteamInfomation.MVVM.Models;


namespace SteamInfomation.MVVM.ViewModels
{
    internal partial class AccountInformationViewModel : ObservableObject
    {
        private readonly SteamApiService _teamApiService;

        public AccountInformationViewModel()
        {
            _teamApiService = new SteamApiService();
        }

        [ObservableProperty]
        private string steamid;
        [ObservableProperty]
        private string gamertag;
        [ObservableProperty]
        private string realname;
        [ObservableProperty]
        private string avatarfullsize;
        [ObservableProperty]
        private string profilelink;


        [RelayCommand]
        public async Task FetchAccountData()
        {
            var steamPlayer = await _teamApiService.GetAccountInformation(Steamid);

            if (steamPlayer != null && steamPlayer.response != null && steamPlayer.response.players.Length > 0)
            {
                Gamertag = steamPlayer.response.players[0].personaname;
                Realname = steamPlayer.response.players[0].realname;
                Avatarfullsize = steamPlayer.response.players[0].avatarfull;
                Profilelink = steamPlayer.response.players[0].profileurl;
            }
        }

    }

}
