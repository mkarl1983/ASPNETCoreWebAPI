using AerosparesWebAPI.Repositories;
using System.Threading.Tasks;

namespace AerosparesWebAPI.Services
{
    public interface ISeedDataService
    {
        Task Initialize(AccountDbContext context);
    }
}
