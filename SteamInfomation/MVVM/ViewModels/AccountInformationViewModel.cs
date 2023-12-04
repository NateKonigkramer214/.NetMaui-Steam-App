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

namespace SteamInfomation.MVVM.ViewModels
{
    // Partial class for the AccountInformationViewModel, extending ObservableObject
    internal partial class AccountInformationViewModel : ObservableObject
    {
        // Private field to hold an instance of SteamApiService
        private readonly SteamApiService _teamApiService;

        // Public property for the command to open a link
        public ICommand OpenLinkCommand { get; }

        // Constructor for the AccountInformationViewModel
        public AccountInformationViewModel()
        {
            // Initialize the OpenLinkCommand with the OpenLink method
            OpenLinkCommand = new Command(OpenLink);

            // Initialize the SteamApiService
            _teamApiService = new SteamApiService();
        }

        // Observable properties for the account information
        [ObservableProperty]
        private string steamid;
        [ObservableProperty]
        private string personaname;
        [ObservableProperty]
        private string realname;
        [ObservableProperty]
        private string avatarfullsize;
        [ObservableProperty]
        private string profilelink;

        // RelayCommand to fetch account data asynchronously
        [RelayCommand]
        public async Task FetchAccountData()
        {
            // Call the SteamApiService to get account information based on Steamid
            var steamPlayer = await _teamApiService.GetAccountInformation(Steamid);

            // Check if the response is not null and contains players
            if (steamPlayer != null && steamPlayer.response != null && steamPlayer.response.players.Length > 0)
            {
                // Update observable properties with fetched data
                Personaname = steamPlayer.response.players[0].personaname;
                Realname = steamPlayer.response.players[0].realname;
                Avatarfullsize = steamPlayer.response.players[0].avatarfull;
                Profilelink = steamPlayer.response.players[0].profileurl;
            }
        }

        // Method to open the link using Xamarin.Essentials Launcher
        private void OpenLink()
        {
            // Navigate to the link or perform any other action
            // You can use Xamarin.Essentials Launcher to open a URL
            Launcher.OpenAsync(new Uri(Profilelink));
        }
    }
}
