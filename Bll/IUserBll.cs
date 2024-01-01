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
        void SignInUser(FullUser user);
        //login user
        UserDto LoginUser(string mail, string password);
        //get all users
        List<UserDto> GetAllUsers();
        //update user
        void UpDateUser(UserDto user);
        //get user by id
        UserDto GetUserById(int id);
        //change status
        void UpDateStatusById(UserDto user);
        //change type
        void UpDateType(int id, int typeId);
    }
}
