using System.Collections.Generic;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly ITokenService _tokenService;
        public UsersController(DataContext context, ITokenService tokenService)
        {
            _tokenService = tokenService;
            _context = context;
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _context.ftstaff.ToListAsync();
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user = await _context.ftstaff
                .SingleOrDefaultAsync(x => x.dbstffid.ToLower() == loginDto.dbstffid.ToLower());

            if (user == null) return Unauthorized("Invalid username");

            if (user.dbstffpswd.ToLower() != loginDto.dbstffpswd.ToLower()) return Unauthorized("Invalid password");

            return new UserDto
            {
                dbstffid = user.dbstffid,
                Token = _tokenService.CreateToken(user)
            };
        }
    }
}