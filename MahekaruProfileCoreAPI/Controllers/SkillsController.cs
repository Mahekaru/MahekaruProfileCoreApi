using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MahekaruProfileCoreAPI.Data;
using MahekaruProfileCoreAPI.Models;

namespace MahekaruProfileCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private readonly MahekaruProfileCoreAPIContext _context;

        public SkillsController(MahekaruProfileCoreAPIContext context)
        {
            _context = context;
        }

        // GET: api/Skills
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SkillsModel>>> GetSkills()
        {
            return await _context.Skills.ToListAsync();
        }

        // GET: api/Skills/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SkillsModel>> GetSkills(int id)
        {
            var skills = await _context.Skills.FindAsync(id);

            if (skills == null)
            {
                return NotFound();
            }

            return skills;
        }

        //// PUT: api/Skills/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutSkills(int id, SkillsModel skills)
        //{
        //    if (id != skills.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(skills).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SkillsExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Skills
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<SkillsModel>> PostSkills(SkillsModel skills)
        //{
        //    _context.Skills.Add(skills);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetSkills", new { id = skills.Id }, skills);
        //}

        //// DELETE: api/Skills/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteSkills(int id)
        //{
        //    var skills = await _context.Skills.FindAsync(id);
        //    if (skills == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Skills.Remove(skills);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool SkillsExists(int id)
        {
            return _context.Skills.Any(e => e.Id == id);
        }
    }
}
