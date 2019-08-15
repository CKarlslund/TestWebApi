using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestWebApi1.Domain.Tabs
{
    public interface ITabRepository
    {
        Task<List<Tab>> GetAllAsync();
    }
}
