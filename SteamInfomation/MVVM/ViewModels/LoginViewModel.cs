using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SteamInfomation.MVVM.ViewModels
{
    public class LoginViewModel : BindableObject
    {
        private string _username;
        private string _password;

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand => new Command(OnLoginClicked);

        private void OnLoginClicked()
        {
            if (DatabaseHelper.UserExists(Username, Password))
            {
                // Navigate to the next page or perform other actions for successful login
                // For example, you might want to use Navigation.PushAsync() to navigate to a new page.
            }
            else
            {
                // Show an error message or perform other actions for failed login
            }
        }
    }
}
