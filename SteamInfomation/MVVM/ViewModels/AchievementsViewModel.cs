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
    internal partial class AchievementsViewModel : ObservableObject
    {
        private readonly SteamApiService _teamApiService;
        private int _achievedCount;

        public AchievementsViewModel()
        {
            _teamApiService = new SteamApiService();
        }

        public int AchievedCount
        {
            get { return _achievedCount; }
            set
            {
                if (_achievedCount != value)
                {
                    _achievedCount = value;
                    OnPropertyChanged(nameof(AchievedCount));
                }
            }
        }

        [ObservableProperty]
        private string steamid;
        [ObservableProperty]
        private string appid;
        [ObservableProperty]
        private string gameName;
        [ObservableProperty]
        private string achievements;
        [ObservableProperty]
        private int achieved;
        [ObservableProperty]
        private string unlocktime;

        [RelayCommand]
        public async Task FetchAchievementsData()
        {
            var steamAchiv = await _teamApiService.GettingGameAchivements(Steamid, Appid);

            if (steamAchiv != null && steamAchiv.playerstats != null && steamAchiv.playerstats.achievements.Length > 0)
            {
                // Assuming you want to display the count of achievements in your UI
                AchievedCount = steamAchiv.playerstats.achievements.Count();

                // Other properties remain the same
                Unlocktime = steamAchiv.playerstats.achievements[0].unlocktime.ToString(); // Convert to string if needed
                Steamid = steamAchiv.playerstats.steamID;
                Appid = ""; // You need to set this property as well

                // Assuming you want to concatenate all achievement names into a single string
                Achievements = string.Join(", ", steamAchiv.playerstats.achievements.Select(a => a.apiname));

                // Assuming you want to set the game name
                GameName = steamAchiv.playerstats.gameName;
            }
        }
    }
}
