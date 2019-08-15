using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebApi1.Domain.Tabs;
using TestWebApi1.Infrastructure.Persistence;

namespace TestWebApi1.Domain.Services
{
    public interface ISearchService
    {
        Task<IEnumerable<Tab>> GetAllAsync();
    }
}
