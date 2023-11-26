using SteamInfomation.MVVM.Data;
using SteamInfomation.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SteamInfomation.MVVM.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string _username;
        private string _password;

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

        public ICommand LoginCommand => new Command(OnLogin);

        private void OnLogin()
        {
            var user = DatabaseService.Database.Table<User>().FirstOrDefault(u => u.Username == Username && u.Password == Password);

            if (user != null)
            {
                // Successful login
                // Navigate to the next page or perform any other action
                // You may want to use a navigation service for this purpose
            }
            else
            {
                // Failed login
                // Show an error message or perform other actions
            }
        }
    }

}
