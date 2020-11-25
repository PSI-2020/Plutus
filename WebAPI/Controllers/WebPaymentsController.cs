using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebPaymentsController : ControllerBase
    {
        private readonly PaymentsContext _context;

        public WebPaymentsController(PaymentsContext context)
        {
            _context = context;
        }

        // GET: api/WebPayments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WebPayment>>> GetWebPayments()
        {
            return await _context.WebPayments.ToListAsync();
        }

        // GET: api/WebPayments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WebPayment>> GetWebPayment(string id)
        {
            var webPayment = await _context.WebPayments.FindAsync(id);

            if (webPayment == null)
            {
                return NotFound();
            }

            return webPayment;
        }

        // PUT: api/WebPayments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWebPayment(string id, WebPayment webPayment)
        {
            if (id != webPayment.Name)
            {
                return BadRequest();
            }

            _context.Entry(webPayment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WebPaymentExists(id))
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

        // POST: api/WebPayments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<WebPayment>> PostWebPayment(WebPayment webPayment)
        {
            _context.WebPayments.Add(webPayment);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (WebPaymentExists(webPayment.Name))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction(nameof(GetWebPayment), new { id = webPayment.Name }, webPayment);
        }

        // DELETE: api/WebPayments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWebPayment(string id)
        {
            var webPayment = await _context.WebPayments.FindAsync(id);
            if (webPayment == null)
            {
                return NotFound();
            }

            _context.WebPayments.Remove(webPayment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WebPaymentExists(string id)
        {
            return _context.WebPayments.Any(e => e.Name == id);
        }
    }
}
