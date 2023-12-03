using SQLite;
using SteamInfomation.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamInfomation.MVVM.Services
{
    public class DBSS
    {
        readonly SQLiteAsyncConnection database;
        public DBSS(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<US>().Wait();
        }
        public async Task<List<US>> GetSavesAsync()
        {
            return await database.Table<US>().ToListAsync();
        }

        public async Task<int> SaveSavesAsync(US us)
        {
            return await database.InsertAsync(us);
        }
    }
}

