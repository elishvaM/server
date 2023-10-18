using Microsoft.AspNetCore.Mvc;
using Bll;
using Dto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gui.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBll userBll;
        public UserController(IUserBll userBll)
        {
            this.userBll = userBll;
        }
        //make an error
        //[HttpGet]
        //[Route("/GetAllUsers")]
        //after change
        //get all
        [HttpGet("/api/[controller]/GetAllUsers")]
        public List<UserDto> GetAllUsers()
        {
            return userBll.GetAllUsers();
        }
        //get by id
        [HttpGet("/api/[controller]/GetUserById/{id}")]
        public UserDto GetUserById(int id)
        {
            return userBll.GetUserById(id);
        }
        //signin
        [HttpPost("/api/[controller]/SignIn")]
        public object SignIn([FromBody] UserDto user)
        {
            userBll.SignInUser(user);
            return new { user = user, message = "success" };
        }
        //login
        [HttpPost("/api/[controller]/LogIn/{password}/{email}")]
        public object LogIn(string password, string email)
        {
            UserDto user = userBll.LoginUser(email, password) ;
            if (user != null) Console.WriteLine(user.Name);
            if (user == null)
                return new { user = user, message = "faild" };
            return new { user = user, message = "succses" };
        }
        //update status
        [HttpPut("/api/[controller]/UpDateStatusById/{id}")]
        public void UpDateStatusById(int id)
        {
            userBll.UpDateStatusById(id);
        }
        [HttpPut("/api/[controller]/UpDateUser")]
        public void UpDateUser([FromBody] UserDto user)
        {
            userBll.UpDateUser(user);
        }
    }
}
