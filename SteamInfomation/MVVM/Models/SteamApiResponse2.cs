using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace SteamInfomation.MVVM.Models
{
    public class SteamApiResponse2
    {
        [JsonPropertyName("Response")]
        public Response response { get; set; }

        public class Response
        {
            [JsonPropertyName("Total_count")]
            public int total_count { get; set; }

            [JsonPropertyName("Games")]
            public Game[] games { get; set; }
        }

        public class Game
        {
            [JsonPropertyName("Appid")]
            public int appid {get; set; }

            [JsonPropertyName("Name")]
            public string name { get; set; }

            [JsonPropertyName("Playtime_2weeks")]
            public int playtime_2weeks { get; set; }

            [JsonPropertyName("Playtime_forever")]
            public int playtime_forever { get; set; }

            [JsonPropertyName("Img_icon_url")]
            public string img_icon_url { get; set; }

            [JsonPropertyName("Playtime_windows_forever")]
            public int playtime_windows_forever { get; set; }

            [JsonPropertyName("Playtime_mac_forever")]
            public int playtime_mac_forever { get; set; }

            [JsonPropertyName("Playtime_linux_forever")]
            public int playtime_linux_forever { get; set; }
        }
    }
}
