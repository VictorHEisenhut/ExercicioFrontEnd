using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AuthenticationAPI.Data;
using AuthenticationAPI.Models;
using Microsoft.IdentityModel.Tokens;
using AuthenticationAPI.Config;
using AuthenticationAPI.Dtos;

namespace AuthenticationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UserDbContext _context;

        public UsersController(UserDbContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

   
        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("login")]
        public async Task<ActionResult<dynamic>> Login(UserDto user)
        {
            string token = "";
            var users = await _context.Users.ToListAsync();
            var userLogado = (from u in users where u.Username == user.Username & u.Password == user.Password select u).ToList();
                //users.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();

            if (userLogado.IsNullOrEmpty())
            {
                return NotFound();
            }

            token = TokenService.GenerateToken(userLogado[0]);

            return new { token = token };
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
