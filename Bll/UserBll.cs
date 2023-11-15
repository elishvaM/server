using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;
using Dto;
using AutoMapper;
namespace Bll
{

    public class UserBll : IUserBll
    {
        private readonly IUserDal userDal;
        private readonly IMapper mapper;
        public UserBll(IUserDal userDal, IMapper mapper)
        {
            this.userDal = userDal;
            this.mapper = mapper;
        }
        public List<UserDto> GetAllUsers()
        {
            return mapper.Map<List<UserDto>>(this.userDal.GetAllUsers());
        }
        public UserDto GetUserById(int id)
        {
            return mapper.Map<UserDto>(this.userDal.GetUserById(id));
        }
        public UserDto LoginUser(string mail, string password)
        {
            return mapper.Map<UserDto>(this.userDal.LoginUser(mail, password));
        }
        public void SignInUser(UserDto user)//ללא קשרי גומלין האובייקט עצמו
        {
            // ולכן הצטרכנו להמירו user מקבל אובייקט מסוג  userdal 
            this.userDal.SignInUser(mapper.Map<User>(user));
        }

        public void UpDateStatusById(UserDto user)
        {
            this.userDal.UpDateStatusById(mapper.Map<User>(user));
        }
        public void UpDateUser(UserDto user)
        {
            // ללא קשרי גומלין UserDto  מקבלת 
            //שולחת לפונקציה שמקבלת עם קשרי גומלין
            this.userDal.UpDateUser(mapper.Map<User>(user));
        }
    }
}

