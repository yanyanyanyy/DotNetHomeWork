using assignment9.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace webapi.Controllers
{
    [Route("api/Order")]
    [ApiController]
    public class LogInController : ControllerBase
    {
        private readonly OrderDbContext _context;

        public LogInController(OrderDbContext context)
        {
            _context = context;
        }

        // GET: api/LogIn
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<Order>>> Getorder()
        {
            if (_context.order == null)
            {
                return NotFound();
            }
            return await _context.order.ToListAsync();
        }

        // GET: api/LogIn/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            if (_context.order == null)
            {
                return NotFound();
            }
            var order = await _context.order.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // PUT: api/LogIn/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(string id, Order order)
        {
            if (id != order.OrderId)
            {
                return BadRequest();
            }

            _context.Entry(order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/LogIn
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
            if (_context.order == null)
            {
                return Problem("Entity set 'LogInContext.order'  is null.");
            }
            _context.order.Add(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrder", new { id = order.OrderId }, order);
        }

        // DELETE: api/LogIn/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            if (_context.order == null)
            {
                return NotFound();
            }
            var order = await _context.order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.order.Remove(order);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderExists(string id)
        {
            return (_context.order?.Any(e => e.OrderId == id)).GetValueOrDefault();
        }
    }
}