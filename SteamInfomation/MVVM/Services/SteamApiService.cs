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
    // Internal class for interacting with the Steam API
    internal class SteamApiService
    {
        // HttpClient instances for making API requests
        private readonly HttpClient _httpClient;
        private readonly HttpClient _httpClient2;

        // Constructor for SteamApiService
        public SteamApiService()
        {
            // Initialize the first HttpClient instance for the main API
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Constants.Constants.API_BASE_URL);

            // API2: Initialize the second HttpClient instance for a secondary API
            _httpClient2 = new HttpClient();
            _httpClient2.BaseAddress = new Uri(Constants.Constants.API_BASE_URL2);
        }

        // Method to get account information from the Steam API
        public async Task<SteamApiResponse> GetAccountInformation(string steamId)
        {
            // Check for internet connectivity before making the API call
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
                return null;

            // Make API request and deserialize the JSON response to SteamApiResponse
            var response = await _httpClient.GetFromJsonAsync<SteamApiResponse>($"?key={Constants.Constants.API_KEY}&steamids={steamId}");
            return response;
        }

        // Method to get game achievements from a secondary Steam API
        public async Task<SteamApiResponse2> GettingGameAchivements(string steamId, string appid)
        {
            // Check for internet connectivity before making the API call
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
                return null;

            // Make API request and deserialize the JSON response to SteamApiResponse2
            var response = await _httpClient2.GetFromJsonAsync<SteamApiResponse2>($"?appid={appid}&key={Constants.Constants.API_KEY}&steamid={steamId}");
            return response;
        }
    }
}
