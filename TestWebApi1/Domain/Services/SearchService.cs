using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestWebApi1.Domain.Tabs;
using TestWebApi1.Infrastructure.Persistence;

namespace TestWebApi1.Domain.Services
{
    public class SearchService : ISearchService
    {
        private readonly ITabRepository tabRepository;

        public SearchService(ITabRepository tabRepository)
        {
            this.tabRepository = tabRepository;
        }

        public async Task<IEnumerable<Tab>> GetAllAsync()
        {
            return await this.tabRepository.GetAllAsync();
        }
    }
}