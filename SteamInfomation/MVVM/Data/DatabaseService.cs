
using SteamInfomation.MVVM.Models;
using SQLite;

namespace SteamInfomation.MVVM.Data
{
    class DatabaseService
    {
        private static SQLiteConnection _database;

        public static SQLiteConnection Database
        {
            get
            {
                if (_database == null)
                {
                    var databasePath = Path.Combine(FileSystem.AppDataDirectory, "SteamApp.db3");
                    _database = new SQLiteConnection(databasePath);
                    _database.CreateTable<User>(); // Create User table
                }
                return _database;
            }
        }
    }
}
