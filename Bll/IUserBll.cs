using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
namespace Bll
{
    public interface IUserBll
    { //thes the functions that will be excueted on the db

        //sign user
        int SignInUser(FullUser user);
        //login user
        FullUser LoginUser(string mail, string password);
        //get all users
        List<UserDto> GetAllUsers();
        //update user
        void UpDateUser(FullUser user);
        //get user by id
        UserDto GetUserById(int id);
        //change status
        void UpDateStatusById(UserDto user);
        //change type
        void UpDateType(int id, int typeId);

        bool SendEmailOnly(string to, string subject);

        UserDto ForgetPassword(string oneUsePassword, string email);
    }
}
