using Newtonsoft.Json;
using SteamInfomation.MVVM.Models;

using System.Collections.ObjectModel;
using System.ComponentModel;


namespace SteamInfomation.MVVM.ViewModels
{
    public class SteamViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<SteamGame> _games;

        public ObservableCollection<SteamGame> Games
        {
            get => _games;
            set
            {
                _games = value;
                OnPropertyChanged(nameof(Games));
            }
        }

        public async Task LoadGamesAsync()
        {
            string apiKey = "117134DA22288BA65A00782B19A6CD95";
            string steamId = "YOUR_STEAM_USER_ID";
            string apiUrl = $"http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key={apiKey}&steamid={steamId}&format=json";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();

                        // Parse the JSON response and populate the Games property
                        Games = ParseSteamApiResponse(content);
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                }
            }
        }

        private ObservableCollection<SteamGame> ParseSteamApiResponse(string response)
        {
            var steamGamesResponse = JsonConvert.DeserializeObject<SteamGamesResponse>(response);

            // Check if the response contains games
            if (steamGamesResponse?.Response?.Games != null)
            {
                return new ObservableCollection<SteamGame>(steamGamesResponse.Response.Games);
            }
            else
            {
                // Handle the case where no games are found
                Console.WriteLine("No games found in the response.");
                return new ObservableCollection<SteamGame>();
            }
        }

        // INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
