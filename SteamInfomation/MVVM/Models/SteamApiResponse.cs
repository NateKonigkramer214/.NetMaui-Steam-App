using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace SteamInfomation.MVVM.Models
{
    public class SteamApiResponse
    {
        [JsonPropertyName("Response")]
        public Response response { get; set; }


        public class Response
        {
            [JsonPropertyName("Players")]
            public Player[] players { get; set; }

            [JsonPropertyName("Total_count")]
            public int total_count { get; set; }

            [JsonPropertyName("Games")]
            public Game[] games { get; set; }
        }

        public class Player
        {
            [JsonPropertyName("Steamid")]
            public string steamid { get; set; }
            [JsonPropertyName("Communityvisibilitystate")]
            public int communityvisibilitystate { get; set; }
            [JsonPropertyName("Profilestate")]
            public int profilestate { get; set; }
            [JsonPropertyName("Personname")]
            public string personaname { get; set; }
            [JsonPropertyName("Profileurl")]
            public string profileurl { get; set; }
            [JsonPropertyName("Avatar")]
            public string avatar { get; set; }
            [JsonPropertyName("Avatarmedium")]
            public string avatarmedium { get; set; }
            [JsonPropertyName("Avatarfull")]
            public string avatarfull { get; set; }
            [JsonPropertyName("Avatarhash")]
            public string avatarhash { get; set; }
            [JsonPropertyName("Personastate")]
            public int personastate { get; set; }
            [JsonPropertyName("Realname")]
            public string realname { get; set; }
            [JsonPropertyName("Primaryclanid")]
            public string primaryclanid { get; set; }
            [JsonPropertyName("Timecreated")]
            public int timecreated { get; set; }
            [JsonPropertyName("Personastateflags")]
            public int personastateflags { get; set; }
            [JsonPropertyName("Loccountrycode")]
            public string loccountrycode { get; set; }
            [JsonPropertyName("Locstatecode")]
            public string locstatecode { get; set; }
            [JsonPropertyName("Loccityid")]
            public int loccityid { get; set; }
        }

        public class Game
        {
            [JsonPropertyName("Appid")]
            public int appid { get; set; }

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
