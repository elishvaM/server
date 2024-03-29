﻿using Entity;
using Microsoft.EntityFrameworkCore;
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
            return this.ElishevaMHadasBListsTripContext.Users.Include(x => x.UserType).ToList();
        }
        public User GetUserById(int id)
        {
            return this.ElishevaMHadasBListsTripContext.Users.FirstOrDefault(x => x.Id == id);
        }
        public User LoginUser(string email, string password)
        {
            return this.ElishevaMHadasBListsTripContext.Users.FirstOrDefault(x => x.Email.ToLower() == email.ToLower() && x.Password == password);
        }
        public User SignInUser(User user)
        {
            if (this.ElishevaMHadasBListsTripContext.Users.Any(x => x.Email == user.Email))
                return null;
            user.UserTypeId = 1;
            user.Status = true;
            //change
            this.ElishevaMHadasBListsTripContext.Users.Add(user);
            //svae
            this.ElishevaMHadasBListsTripContext.SaveChanges();
            return user;
        }

        public void UpDateStatusById(User user)
        {
            //דרך אחת
            //if (user.Status) user.Status = false;
            //else user.Status = true;
            //דרך שניה
            User foundUser = this.ElishevaMHadasBListsTripContext.Users.FirstOrDefault(x => x.Id == user.Id);
            foundUser.Status = !foundUser.Status;
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
        public void UpDateType(int id, int typeId)
        {
            User foundUser = this.ElishevaMHadasBListsTripContext.Users.FirstOrDefault(x => x.Id == id);
            foundUser.UserTypeId = typeId;
            this.ElishevaMHadasBListsTripContext.SaveChanges();
        }

        public User ForgetPassword(string oneUsePassword, string email)
        {
            return this.ElishevaMHadasBListsTripContext.Users.First(x => x.Email == email && x.OneTimePassword == oneUsePassword);
        }

        public void SaveOneUsePassword(string oneUsePassword, string email)
        {
            User foundUser = this.ElishevaMHadasBListsTripContext.Users.FirstOrDefault(x => x.Email == email);
            foundUser.OneTimePassword = oneUsePassword;
            this.ElishevaMHadasBListsTripContext.SaveChanges();
        }
    }
}
