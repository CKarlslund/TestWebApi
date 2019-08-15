using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Threading.Tasks;

using TestWebApi1.Domain.Services;
using TestWebApi1.Domain.Tabs;

namespace TestWebApi1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TabsController : ControllerBase
    {
        public ISearchService SearchService { get; }

        public TabsController(ISearchService searchService)
        {
            SearchService = searchService;
        }

        // GET: api/Search
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tab>>> Get()
        {
            var result = await SearchService.GetAllAsync();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        // GET: api/Search/5
        [HttpGet("{query}", Name = "Get")]
        public string Get(string query, int page, int perPage)
        {
            return "value";
        }

        // POST: api/Search
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Search/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
