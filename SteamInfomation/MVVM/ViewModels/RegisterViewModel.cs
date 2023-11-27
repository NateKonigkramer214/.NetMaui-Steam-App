using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SteamInfomation.MVVM.MainViews;

namespace SteamInfomation.MVVM.ViewModels
{
    public class RegisterViewModel : BindableObject
    {
        private string _newUsername;
        private string _newPassword;
        private string _confirmPassword;

        public string NewUsername
        {
            get => _newUsername;
            set
            {
                _newUsername = value;
                OnPropertyChanged();
            }
        }

        public string NewPassword
        {
            get => _newPassword;
            set
            {
                _newPassword = value;
                OnPropertyChanged();
            }
        }

        public string ConfirmPassword
        {
            get => _confirmPassword;
            set
            {
                _confirmPassword = value;
                OnPropertyChanged();
            }
        }

        public ICommand RegisterCommand => new Command(OnRegisterClicked);

        private void OnRegisterClicked()
        {
            // Check if the user already exists
            if (!DatabaseHelper.UserExists(NewUsername, NewPassword))
            {
                // If the user does not exist, add them to the database
                DatabaseHelper.InsertUser(NewUsername, NewPassword);

                // Optionally, navigate to the login page or perform other actions
                // For example, you might want to use Navigation.PushAsync() to navigate to the login page.
                

            }
            else
            {
                // Show an error message or perform other actions for duplicate user
            }
        }
    }
}
