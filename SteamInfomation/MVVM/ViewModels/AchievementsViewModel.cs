using Newtonsoft.Json;
using SteamInfomation.MVVM.Models;
using SteamInfomation.MVVM.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;

public class AchievementsViewModel : ViewModelBase
{
    private ObservableCollection<Achievement> _achievements;

    public ObservableCollection<Achievement> Achievements
    {
        get => _achievements;
        set
        {
            if (_achievements != value)
            {
                _achievements = value;
                OnPropertyChanged();
            }
        }
    }

    public ICommand LoadAchievementsCommand => new Command(async () => await LoadAchievements());

    private async Task LoadAchievements()
    {
        
        string apiUrl = " http://api.steampowered.com/ISteamUserStats/GetPlayerAchievements/v0001/";

        using (HttpClient client = new HttpClient())
        {
            var response = await client.GetStringAsync(apiUrl);
            var achievements = JsonConvert.DeserializeObject<List<Achievement>>(response);

            Achievements = new ObservableCollection<Achievement>(achievements);
        }
    }
}
