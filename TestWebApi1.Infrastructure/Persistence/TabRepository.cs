using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestWebApi1.Domain.Tabs;

namespace TestWebApi1.Infrastructure.Persistence
{
    public class TabRepository : ITabRepository
    {
        private readonly GuitarChordsDbContext guitarChordsDbContext;

        public TabRepository(GuitarChordsDbContext guitarChordsDbContext)
        {
            this.guitarChordsDbContext = guitarChordsDbContext;
        }
        public Task<List<Tab>> GetAllAsync()
        {
            return guitarChordsDbContext.Tabs.ToListAsync();
        }
    }
}
