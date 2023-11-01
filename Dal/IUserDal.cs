using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Dal
{
    //2
  public interface IUserDal
    {
        //thes the functions that will be excueted on the db

        //sign user
        void SignInUser(User user);
        //login user
        User LoginUser(string mail,string password);
        //get all users
        List<User> GetAllUsers();
        //update user
        void UpDateUser(User user); 
        //get user by id
        User GetUserById(int id);
        //change status
        void UpDateStatusById(User user); 
    }
}
