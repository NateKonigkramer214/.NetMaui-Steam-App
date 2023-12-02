using SQLite;
using SteamInfomation.MVVM.Models;

namespace SteamInfomation.MVVM.Services
{
    public class DBH
    {
        readonly SQLiteAsyncConnection database;

        public DBH(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<User>().Wait();
        }

        public async Task<int> SaveUserAsync(User user)
        {
            return await database.InsertAsync(user);
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await database.Table<User>().ToListAsync();
        }
    }
}
