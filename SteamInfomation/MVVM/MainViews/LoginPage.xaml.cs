using SteamInfomation.MVVM.Models;
using SteamInfomation.MVVM.Services;
using SteamInfomation.MVVM.ViewModels;

namespace SteamInfomation.MVVM.MainViews;

public partial class LoginPage : ContentPage
{
    DBH database;
    public LoginPage()
    {
        InitializeComponent();
        database = new DBH(Path.Combine(FileSystem.AppDataDirectory, "Data\\App.db"));

    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {

        var users = await database.GetUsersAsync();
        var enteredUsername = LoginUsernameEntry.Text;
        var enteredPassword = LoginPasswordEntry.Text;

        var user = users.FirstOrDefault(u => u.Username == enteredUsername && u.Password == enteredPassword);

        if (user != null)
        {
            // Authentication successful, navigate to the next page or perform desired action
            await Navigation.PushAsync(new SteamAppMainPage());
            Console.WriteLine("Login Successful!");
        }
        else
        {
            // Authentication failed, display an error message or take appropriate action
            Console.WriteLine("Login Failed. Invalid username or password.");
        }

    }

    private async void GTRegbtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterPage());
    }


}