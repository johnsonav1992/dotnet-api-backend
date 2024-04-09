using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Dotnet_Web_API.UserModels;

namespace Dotnet_Web_API.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase 
    {
        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            var users = new List<User> {
                new User { Id = 1, FirstName = "John", LastName = "Doe" }
            };

            return Ok(users);
        }
    }
}