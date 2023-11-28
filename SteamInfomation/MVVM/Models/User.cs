using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SteamInfomation.MVVM.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    
    public static class UserRepository
    {
        public static List<User> Users { get; } = new List<User>();
    }

}
