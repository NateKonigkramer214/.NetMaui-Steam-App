using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SteamInfomation.MVVM.Models
{
    internal class SteamApiResponse2
    {
        
        
            [JsonPropertyName("PlayerStats")]
            public Playerstats playerstats { get; set; }


            public class Playerstats
            {
                [JsonPropertyName("SteamID")]
                public string steamID { get; set; }

                [JsonPropertyName("GameName")]
                public string gameName { get; set; }

                [JsonPropertyName("Achievements")]
                public Achievement[] achievements { get; set; }

                [JsonPropertyName("Success")]
                public bool success { get; set; }
            }

        public class Achievement
        {
            [JsonPropertyName("Apiname")]
            public string apiname { get; set; }

            [JsonPropertyName("Achieved")]
            public int achieved { get; set; }

            [JsonPropertyName("Unlockedtime")]
            public int unlocktime { get; set; }
            }
    }
}
