using AerosparesWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace AerosparesWebAPI.Services
{
    public interface IAddressRestService
    {
        Task<AddressDto> GetAddressByIdAsync(int id);

    }
}