using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamInfomation.MVVM.Models
{
    public class SteamGamesResponse
    {
        public SteamGamesResponseData Response { get; set; }
    }

    public class SteamGamesResponseData
    {
        public List<SteamGame> Games { get; set; }
    }
}
