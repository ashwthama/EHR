using EHR.Domain.Model;
using EHR.Service.UserServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EHR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            return Ok(_userService.GetUserList());
        }


        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userService.GetByUserId(id);
        }


        [HttpPost]
        public void Post([FromBody] User user)
        {
            _userService.RegisterUser(user);
        }

        [HttpGet("login")]
        public User Login(string username, string password)
        {
            return _userService.LoginUser(username, password);
        }
    }
}
