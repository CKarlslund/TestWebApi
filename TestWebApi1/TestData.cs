using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebApi1.Domain.Tabs;
using TestWebApi1.Infrastructure.Persistence;

namespace TestWebApi1
{
    public class TestData
    {
        public static void AddTestData(GuitarChordsDbContext context)
        {
            var tab1 = new Tab {Author = "Jörgen Björklund", Title = "Sometimes it hurts"};
            var tab2 = new Tab { Author = "Linnéa Björklund", Title = "Nothing ever changes" };
            var tab3 = new Tab { Author = "Cornelia Karlslund", Title = "Blues i solnedgången" };
            
            var list = new List<Tab> {tab1, tab2, tab3};

            context.Tabs.AddRange(list);

            context.SaveChanges();
        }
    }
}
