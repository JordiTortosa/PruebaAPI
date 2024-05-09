using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using TestAPI.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using TestAPI.Services;

namespace TestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            var users = _userService.getAllUsers();
            return Ok(users);
        }
        
        [HttpGet("Project")]
        public async Task<ActionResult<IEnumerable<User>>> GetUserAndProject()
        {
            var userAndProject = _userService.getUserAndProject();
            return Ok(userAndProject);
        }

        [HttpPost]
        public async Task<ActionResult<User>> addUser(User user)
        {
            var addedUser = _userService.addUser(user);
            return Ok(addedUser);
        }
        /*
        [HttpPut]
        public async Task<ActionResult<User>> changeName(int Id, String Name)
        {
            var changedUser = _userService.changeName(Id, Name);
            return Ok(changedUser);
        }
        */
        [HttpPut]
        public async Task<ActionResult<User>> updateUser(User user)
        {
            var updatedUser = _userService.updateUser(user);
            return Ok(updatedUser);
        }
        
        [HttpDelete]
        public async Task<ActionResult<User>> deleteUser(int Id)
        {
            var changedUser = _userService.deleteUser(Id);
            return Ok(changedUser);
        }

    }    
}