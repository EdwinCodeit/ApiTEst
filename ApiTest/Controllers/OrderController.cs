using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        // GET: api/<OrderController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetAllOrders()
        {
            return await _context.Order.ToListAsync();
        }

        // GET api/<OrderController>/5
        [HttpGet("{WorkOrderNr}")]
        public async Task<ActionResult<Order>> GetOrderByOrderNr(string WorkOrderNr)
        {
            var order = await _context.Order.FirstOrDefaultAsync(o => o.OrderNr == WorkOrderNr);

            if (order == null)
            {
                _logger.LogInformation($"Order with WorkOrderNr '{WorkOrderNr}' not found.");
                return NotFound();           
            
            }

            return Ok(order);
        }

        /*

        // POST api/<OrderController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
