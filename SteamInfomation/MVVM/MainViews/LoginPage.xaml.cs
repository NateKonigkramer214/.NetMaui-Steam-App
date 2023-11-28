using SteamInfomation.MVVM.Models;
using SteamInfomation.MVVM.ViewModels;

namespace SteamInfomation.MVVM.MainViews;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		
	}

    private void OnLoginClicked(object sender, EventArgs e)
    {
        string username = LoginUsernameEntry.Text;
        string password = LoginPasswordEntry.Text;

        var user = UserRepository.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

        if (user != null)
        {
            DisplayAlert("Success", "Login successful!", "OK");
            Navigation.PushAsync(new SteamAppMainPage());
        }
        else
        {
            DisplayAlert("Error", "Invalid username or password", "OK");
        }
    }

    private async void GTRegbtn_Clicked(object sender, EventArgs e)
    {
       await Navigation.PushAsync(new RegisterPage());
    }

    //private void CreateACBtn_Clicked(object sender, EventArgs e)
    //{
    //    Navigation.PushAsync(new RegisterPage());
    //}

    //private void LoginBtn_Clicked(object sender, EventArgs e)
    //{
    //    Navigation.PushAsync(new SteamAppMainPage());
    //}



}