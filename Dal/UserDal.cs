using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    //3
    public class UserDal : IUserDal
    {
        private readonly ElishevaMHadasBListsTripContext ElishevaMHadasBListsTripContext;
        public UserDal(ElishevaMHadasBListsTripContext context)
        {
            this.ElishevaMHadasBListsTripContext = context;
        }
        public List<User> GetAllUsers()
        {
            return this.ElishevaMHadasBListsTripContext.Users.ToList();
        }
        public User GetUserById(int id)
        {
            return this.ElishevaMHadasBListsTripContext.Users.FirstOrDefault(x => x.Id == id);
        }
        public User LoginUser(string email, string password)
        {

            return this.ElishevaMHadasBListsTripContext.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
        }
        public void SignInUser(User user)
        {

            user.Status = true;
            //change
            this.ElishevaMHadasBListsTripContext.Users.Add(user);
            //svae
            this.ElishevaMHadasBListsTripContext.SaveChanges();
        }

        public void UpDateStatusById(int id)
        {
            var u = this.ElishevaMHadasBListsTripContext.Users.FirstOrDefault(x => x.Id == id);
            u.Status = !u.Status;
            this.ElishevaMHadasBListsTripContext.SaveChanges();
        }
        public void UpDateUser(User user)
        {
            var u = this.ElishevaMHadasBListsTripContext.Users.FirstOrDefault(x => x.Id == user.Id);
            u.Email = user.Email;
            u.DateBorn = user.DateBorn;
            u.Password = user.Password;
            u.Phone = user.Phone;
            u.Name = user.Name;
            this.ElishevaMHadasBListsTripContext.SaveChanges();
        }
    }
}
