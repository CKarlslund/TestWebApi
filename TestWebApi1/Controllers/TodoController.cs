//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//using System.Collections.Generic;
//using System.Threading.Tasks;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace TestWebApi1.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class TodoController : ControllerBase
//    {
//        private readonly TodoContext _context;

//        public TodoController(TodoContext context)
//        {
//            _context = context;
//        }

//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
//        {
//            return await _context.TodoItems.ToListAsync();
//        }

//        [HttpGet("{id}")]
//        public async Task<ActionResult<TodoItem>> GetTodoItem(long id)
//        {
//            var todoItem = await _context.TodoItems.FindAsync(id);

//            if (todoItem == null)
//            {
//                return NotFound();
//            }

//            return Ok(todoItem);
//        }

//        // POST: api/Todo
//        [HttpPost]
//        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem item)
//        {
//            _context.TodoItems.Add(item);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction(nameof(GetTodoItem), new { id = item.Id }, item);
//        }

//        // PUT: api/Todo/5
//        [HttpPut("{id}")]
//        public async Task<IActionResult> PutTodoItem(long id, TodoItem item)
//        {
//            if (id != item.Id)
//            {
//                return BadRequest();
//            }

//            _context.Entry(item).State = EntityState.Modified;
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }

//        // DELETE: api/Todo/5
//        [HttpDelete("{id}")]
//        public async Task<IActionResult> DeleteTodoItem(long id)
//        {
//            var todoItem = await _context.TodoItems.FindAsync(id);

//            if (todoItem == null)
//            {
//                return NotFound();
//            }

//            _context.TodoItems.Remove(todoItem);
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }

//        //// GET: api/<controller>
//        //[HttpGet]
//        //public IEnumerable<string> Get()
//        //{
//        //    return new string[] { "value1", "value2" };
//        //}

//        //// GET api/<controller>/5
//        //[HttpGet("{id}")]
//        //public string Get(int id)
//        //{
//        //    return "value";
//        //}

//        //// POST api/<controller>
//        //[HttpPost]
//        //public void Post([FromBody]string value)
//        //{
//        //}

//        //// PUT api/<controller>/5
//        //[HttpPut("{id}")]
//        //public void Put(int id, [FromBody]string value)
//        //{
//        //}

//        //// DELETE api/<controller>/5
//        //[HttpDelete("{id}")]
//        //public void Delete(int id)
//        //{
//        //}
//    }
//}
