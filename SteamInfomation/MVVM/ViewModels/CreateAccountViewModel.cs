using SteamInfomation.MVVM.Data;
using SteamInfomation.MVVM.Models;
using System.Windows.Input;

namespace SteamInfomation.MVVM.ViewModels
{
    public class CreateAccountViewModel : ViewModelBase
    {
        private string _username;
        private string _password;
        private string _confirmPassword;
        private string _errorMessage;

        public string Username
        {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged();
                }
            }
        }

        public string ConfirmPassword
        {
            get => _confirmPassword;
            set
            {
                if (_confirmPassword != value)
                {
                    _confirmPassword = value;
                    OnPropertyChanged();
                }
            }
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                if (_errorMessage != value)
                {
                    _errorMessage = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand CreateAccountCommand => new Command(OnCreateAccount);

        private void OnCreateAccount()
        {
            if (Password != ConfirmPassword)
            {
                // Passwords do not match
                ErrorMessage = "Passwords do not match.";
                return;
            }

            var user = new User
            {
                Username = Username,
                Password = Password
            };

            DatabaseService.Database.Insert(user);

            // Account created successfully
            // You may want to navigate to the login page or perform other actions
        }
    }

}
