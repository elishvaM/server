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
        public ActionResult SignIn([FromBody] FullUser user)
        {
            if (userBll.GetAllUsers().Contains(user))
                return BadRequest("משתמש זה קיים");
            int id = userBll.SignInUser(user);
            UserDto signed = userBll.GetUserById(id);
            return Ok(signed);
        }
        //login
        [HttpPost("/api/[controller]/LogIn")]
        public ActionResult LogIn(UserLogin userInput)
        {
            FullUser user = userBll.LoginUser(userInput.Email, userInput.Password);
            if (user == null)
                return BadRequest("פרטיך שגויים, אנא נסה שנית");// { user = user, message = "faild" };
            return Ok(user);
        }
        //update status
        [HttpPut("/api/[controller]/UpDateStatusById")]
        public void UpDateStatusById(UserDto user)
        {
            userBll.UpDateStatusById(user);
        }
        //update user
        [HttpPost("/api/[controller]/UpDateUser")]
        public FullUser UpDateUser([FromBody] FullUser user)
        {
            userBll.UpDateUser(user);
            return user;
        }
        //update type
        [HttpPost("/api/[controller]/UpDateType")]
        public ActionResult UpDateType([FromBody] UserAndType user)
        {
            userBll.UpDateType(user.Id, user.TypeId);
            return Ok("שינוי בוצע בהצלחה");
        }

        [HttpPost("/api/[controller]/ForgetPassword/{oneUsePassword}/{email}")]
        public UserDto ForgetPassword(string oneUsePassword, string email)
        {
            return userBll.ForgetPassword(oneUsePassword, email);
        }

    }
}
