
using SteamInfomation.MVVM.Models;
using SteamInfomation.MVVM.Services;

namespace SteamInfomation.MVVM.MainViews;
public partial class RegisterPage : ContentPage
{
    //List<User> users = new List<User>();

    DBH database;

    public RegisterPage()
    {
        InitializeComponent();
        database = new DBH(Path.Combine(FileSystem.AppDataDirectory, "Data\\App.db"));

    }

    public async void OnRegisterClicked(object sender, EventArgs e)
    {
        var user = new User
        {
            Username = UsernameEntry.Text,
            Password = PasswordEntry.Text
        };

        await database.SaveUserAsync(user);
        await DisplayAlert("Success", "Register successful!", "OK");

    }

}