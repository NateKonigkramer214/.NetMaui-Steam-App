
using SteamInfomation.MVVM.Models;
using SteamInfomation.MVVM.ViewModels;

namespace SteamInfomation.MVVM.MainViews;
public partial class RegisterPage : ContentPage
{
    List<User> users = new List<User>();
    public RegisterPage()
    {
        InitializeComponent();

    }

    private void OnRegisterClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
        {
            var user = new User { Username = username, Password = password };
            UserRepository.Users.Add(user);

            DisplayAlert("Success", "Registration successful!", "OK");
        }
        else
        {
            DisplayAlert("Error", "Please enter a username and password", "OK");
        }
    }

    //  private void Button_Clicked(object sender, EventArgs e)
    //  {
    //Navigation.PushAsync(new LoginPage());
    //  }
}