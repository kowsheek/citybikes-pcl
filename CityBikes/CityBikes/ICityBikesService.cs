using CityBikes.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CityBikes
{
    public interface ICityBikesService
    {
        Task<List<Network>> GetNetworksAsync();
        Task<List<Station>> GetStationsAsync(Network network);
        Task<List<Station>> GetStationsAsync(string networkName);
    }
}
