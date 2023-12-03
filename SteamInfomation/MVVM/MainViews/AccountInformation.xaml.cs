using Microsoft.Maui.Controls;
using SteamInfomation.MVVM.Models;
using SteamInfomation.MVVM.Services;
using SteamInfomation.MVVM.ViewModels;
using System.Collections.ObjectModel;

namespace SteamInfomation.MVVM.MainViews
{
    public partial class AccountInformation : ContentPage
    {
        DBSS database;
        ObservableCollection<string> steamIdList; // List to store SteamIDs for Picker

        public AccountInformation()
        {
            InitializeComponent();
            BindingContext = new AccountInformationViewModel();
            database = new DBSS(Path.Combine(FileSystem.AppDataDirectory, "Data\\Saves.db"));

            // Initialize the ObservableCollection
            steamIdList = new ObservableCollection<string>();
            SPick.ItemsSource = steamIdList;

            // Fetch and set data for the Picker
            FetchSteamIDs();
        }

        private async void FetchSteamIDs()
        {
            // Fetch SteamIDs from the database
            var steamIds = await database.GetSavesAsync();

            // Update ObservableCollection with fetched SteamIDs
            steamIdList.Clear();
            foreach (var id in steamIds)
            {
                steamIdList.Add(id.SteamID);
            }
        }

        private async void SaveBTN_Clicked(object sender, EventArgs e)
        {

            var us = new US
            {
                SteamID = steamIdEntry.Text
            };
            

            await database.SaveSavesAsync(us);

            // After saving, update the Picker with the new data
            FetchSteamIDs();
            Console.WriteLine("SteamID has been saved");
        }

        private void SPick_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the Entry with the selected SteamID from the Picker
            var selectedSteamID = SPick.SelectedItem as string;
            steamIdEntry.Text = selectedSteamID;
        }
    }
}
