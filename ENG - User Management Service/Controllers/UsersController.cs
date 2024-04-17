using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ENG___User_Management_Service.Context;
using ENG___User_Management_Service.Models;
using Newtonsoft.Json.Linq;
using ENG___User_Management_Service.DTOs;

namespace ENG___User_Management_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Users --GET ACTIVE USERS--
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetActiveUsers()
        {
            return await _context.Users.Where(u => u.Active).ToListAsync();
        }

        // GET: api/Users/{id} --GET USER BY ID--
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/Users/{id} --UPDATE ACTIVE STATUS--
        [HttpPut("{id}")]
        public async Task<IActionResult> ChangeUserStatus(int id, [FromBody] UserStatusDTO userDTO )
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                   return NotFound();
            }

            user.Active = userDTO.Active;
            await _context.SaveChangesAsync();
            return Ok(user);
        }

        // POST: api/Users --CREATE USER--
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // DELETE: api/Users/{id} --DELETE USER--
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}