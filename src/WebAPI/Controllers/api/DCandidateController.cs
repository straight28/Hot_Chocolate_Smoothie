using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class DCandidateController : ControllerBase
    {
        private readonly Donation2DBcontext _dbContext;

        public DCandidateController(Donation2DBcontext dbContext)
        {
            _dbContext = dbContext;
        }


        // GET: api/DCandidate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DCandidate>>> GetDCandidates()
        {
            return await _dbContext.DCandidates.ToListAsync();
        }

        // GET api/DCandidate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DCandidate>> GetDCandidate(int id)
        {

            var dCandidate = await _dbContext.DCandidates.FindAsync(id);

            if(dCandidate == null)
            {
                return NotFound();
            }

            return dCandidate;
        }

        // PUT api/DCandidate/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDCandidate(int id, DCandidate dCandidate)
        {
            dCandidate.Id = id;
            _dbContext.Entry(dCandidate).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DCandidateExist(id))
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

        [HttpPost]
        public  async Task<ActionResult<DCandidate>> PostDCandidate(DCandidate dCandidate)
        {
            _dbContext.DCandidates.Add(dCandidate);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction("GetDCandidate", new { id = dCandidate.Id}, dCandidate);
        }


        // api/DCandidate/5
        [HttpDelete]
        public async Task<ActionResult<DCandidate>> DeleteDCandidate(int id)
        {
            var dCandidate = await _dbContext.DCandidates.FindAsync(id);

            if(dCandidate == null)
            {
                return NotFound();
            }

            _dbContext.DCandidates.Remove(dCandidate);
            await _dbContext.SaveChangesAsync();

            return dCandidate;
        }


        private bool DCandidateExist(int id)
        {
            return _dbContext.DCandidates.Any(t => t.Id == id);
        }



    }
}
