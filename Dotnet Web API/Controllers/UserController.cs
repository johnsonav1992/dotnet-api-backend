using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserModels;

namespace UsersAPI.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase 
    {
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = new List<User> {
                new User { Id = 1, FirstName = "John", LastName = "Doe" }
            };

            return Ok(users);
        }
    }
}