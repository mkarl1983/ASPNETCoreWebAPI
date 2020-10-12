using System;
using AerosparesWebAPI.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Xunit;

namespace AerosparesWebAPI.Tests
{
    public class AddressRestServiceTests
    {
        [Fact]
        public async Task Get_Existing_Todo()
        {
            var services = new ServiceCollection();
            services.UseServices();
            var serviceProvider = services.BuildServiceProvider();

            var service = serviceProvider.GetRequiredService<IAddressRestService>();

            var task = await service.GetAddressByIdAsync(1);

            Assert.NotNull(task);
        }
    }
}