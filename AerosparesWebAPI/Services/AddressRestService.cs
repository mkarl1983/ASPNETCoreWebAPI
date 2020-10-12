using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AerosparesWebAPI.Models;
using Newtonsoft.Json;

namespace AerosparesWebAPI.Services
{
    public class AddressRestService : IAddressRestService
    {
        private const string BaseUrl = "https://randomuser.me/api/?results=1&inc=location&nat=gb";
        private readonly HttpClient _client;

       

        public AddressRestService(HttpClient client)
        {
            _client = client;
        }

        public async Task<AddressDto> GetAddressByIdAsync(int id)
        {
             var httpResponse = await _client.GetAsync($"{BaseUrl}");
            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot retrieve address");
            }
            var content = await httpResponse.Content.ReadAsStringAsync();
            var resultItem = JsonConvert.DeserializeObject<Root>(content);
            return resultItem.results[0].location;
        }

    }
}