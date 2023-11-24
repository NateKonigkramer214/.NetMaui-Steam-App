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
        private async Task FetchAccountData()
        {
            var steamApiResponse = await _teamApiService.GetAccountInformation(Steamid);
            if (steamApiResponse != null)
            {
                
            }
        }
    }

}
