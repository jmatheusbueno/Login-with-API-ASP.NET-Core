using Microsoft.AspNetCore.Mvc;
using Models.User;
using Data.DataContext;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Controllers
{
    [ApiController]
    [Route("v1/users")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<User>>> Get([FromServices] DataContext context)
        {
            var users = await context.User.AsNoTracking().ToListAsync();
            return users;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<User>> Post([FromServices] DataContext context, [FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                context.User.Add(user);
                await context.SaveChangesAsync();
                return user;
            }
            else
                return BadRequest(ModelState);
        }

        [HttpPost("login")]
        public async Task<ActionResult<User>> Login([FromServices] DataContext context, [FromBody] User user)
        {
            var users = await context.User.AsNoTracking().ToListAsync();
            var registeredUser = users.Find(u => u.Username == user.Username && u.Password == user.Password);
            if (registeredUser?.Username == user.Username)
                return registeredUser;
            else
                return BadRequest("Esta conta não está cadastrada");
        }

    }
}