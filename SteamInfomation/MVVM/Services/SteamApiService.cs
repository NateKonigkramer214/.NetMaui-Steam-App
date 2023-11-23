using SteamInfomation.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace SteamInfomation.MVVM.Services
{
    internal class SteamApiService
    {
        private readonly HttpClient _httpClient;

        public SteamApiService() 
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Constants.Constants.API_BASE_URL);
        }

        public async Task<SteamApiService> GetAccountInformation(string SteamId)
        {
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
                return null;
            return await _httpClient.GetFromJsonAsync<SteamApiService>($"?key={Constants.Constants.API_KEY}&steamids={SteamId}");
        }

    }
}
