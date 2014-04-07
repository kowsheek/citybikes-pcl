using CityBikes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CityBikes
{
    public class CityBikesService : ICityBikesService
    {
        private const string ApiRoot = "http://api.citybik.es/";
        private HttpClient httpClient;

        public CityBikesService()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<Network>> GetNetworksAsync()
        {
            return await ExecuteApiCallAsync<Network>("networks");
        }

        public async Task<List<Station>> GetStationsAsync(Network network)
        {
            return await ExecuteApiCallAsync<Station>(network.Name);
        }

        public async Task<List<Station>> GetStationsAsync(string networkName)
        {
            return await ExecuteApiCallAsync<Station>(networkName);
        }

        private async Task<List<T>> ExecuteApiCallAsync<T>(string call, string format = "json")
        {
            var resultString = await httpClient.GetStringAsync(string.Format("{0}/{1}.{2}", ApiRoot, call, format));
            return await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<List<T>>(resultString));
        }
    }
}
