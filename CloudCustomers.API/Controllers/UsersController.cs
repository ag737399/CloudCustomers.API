using CloudCustomers.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CloudCustomers.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
         _usersService = usersService;
        }

        [HttpGet(Name = "GetUsers")]
        public async Task<IActionResult> Get()
        {
            //Dependency Inversion Principle-------- High level modules should not depend on low-level module.Both should depend on abstractions.
            //Abstractions should not depend on details.Details(i.e. implementations)should depend on abstractions.
            var users=await _usersService.GetAllUsers();
            return Ok("all good");
        }
    }
}