using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Authorize]
    public class KeywordsController : BaseApiController
    {
        private readonly DataContext _context;
        public KeywordsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Keywords>>> GetKeywords()
        {
            return await _context.ftkeywords.ToListAsync();

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Keywords>> GetKeyword(int id)
        {
            return await _context.ftkeywords.FindAsync(id);
        }
    }
}