using SQLite;
using SteamInfomation.MVVM.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

public static class DatabaseHelper
{
    private const string DatabaseName = "SteamApp.db";

    public static void InitializeDatabase()
    {
        using (SQLiteConnection db = new SQLiteConnection(DatabasePath))
        {
            db.CreateTable<User>();
        }
    }

    public static void InsertUser(string username, string password)
    {
        using (SQLiteConnection db = new SQLiteConnection(DatabasePath))
        {
            var user = new User { Username = username, Password = password };
            db.Insert(user);
        }
    }

    public static bool UserExists(string username, string password)
    {
        using (SQLiteConnection db = new SQLiteConnection(DatabasePath))
        {
            var count = db.Table<User>().Count(u => u.Username == username && u.Password == password);
            return count > 0;
        }
    }

    private static string DatabasePath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DatabaseName);
}

[Table("Users")]
public class User
{
    [PrimaryKey, AutoIncrement, Column("Id")]
    public int Id { get; set; }

    [MaxLength(50), Unique]
    public string Username { get; set; }

    [MaxLength(50)]
    public string Password { get; set; }
}

