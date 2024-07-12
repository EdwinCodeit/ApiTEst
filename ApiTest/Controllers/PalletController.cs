using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalletController : ControllerBase
    {
        private readonly AppDbContext _context;
        public PalletController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<PalletController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pallet>>> GetAllPallets()
        {
            return await _context.Pallet.ToListAsync();
        }

        // GET api/<PalletController>/5
        [HttpGet("{SSCC}")]
        public async Task<ActionResult<IEnumerable<Pallet>>> GetPalletBySSCC(int SSCC)
        {
            var pallet = await _context.Pallet.FindAsync(SSCC);

            if (pallet == null) 
            { 
                return NotFound();
            
            }

            return Ok(pallet);
        }
        /*
        // POST api/<PalletController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PalletController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PalletController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
