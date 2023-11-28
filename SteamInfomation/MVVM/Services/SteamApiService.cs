using SteamInfomation.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SteamInfomation.MVVM.Services
{
    internal class SteamApiService
    {
        private readonly HttpClient _httpClient;
        private readonly HttpClient _httpClient2;


        public SteamApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Constants.Constants.API_BASE_URL);

            //API2

            _httpClient2 = new HttpClient();
            _httpClient2.BaseAddress = new Uri(Constants.Constants.API_BASE_URL2);

        }

        public async Task<SteamApiResponse> GetAccountInformation(string steamId)
        {
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
                return null;

            var response = await _httpClient.GetFromJsonAsync<SteamApiResponse>($"?key={Constants.Constants.API_KEY}&steamids={steamId}");
            return response;
        }
        public async Task<SteamApiResponse2> GettingGameAchivements(string steamId, string appid)
        {
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
                return null;

            var response = await _httpClient2.GetFromJsonAsync<SteamApiResponse2>($"?appid={appid}&key={Constants.Constants.API_KEY}&steamid={steamId}");
            return response;
        }

    }
}
