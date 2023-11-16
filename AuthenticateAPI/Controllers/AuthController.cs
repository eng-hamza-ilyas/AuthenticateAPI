using AuthenticateAPI.Interfaces;
using AuthenticateAPI.Model;
using AuthenticateAPI.Request_Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthenticateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService) { 
            
            _authService = authService;
        }



        // POST api/<AuthController>
        [HttpPost]
        public string Login([FromBody] LoginRequest loginmode)
        {
                var result = _authService.Login(loginmode);
            return result;
        }

        // PUT api/<AuthController>/5
        [HttpPost("AddUser")]
        public User AddUser([FromBody] User user)
        {
            var aduser = _authService.AddUser(user);
            return aduser;
        }

    }
}
