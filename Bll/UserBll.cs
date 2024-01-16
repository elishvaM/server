using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;
using Dto;
using AutoMapper;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
//using GemBox.Spreadsheet;
//using MailKit.Net.Smtp;
//using MimeKit;
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
        public FullUser LoginUser(string mail, string password)
        {
            return mapper.Map<FullUser>(this.userDal.LoginUser(mail, password));
        }
        public int SignInUser(FullUser user)
        {
            return this.userDal.SignInUser(mapper.Map<User>(user));
        }

        public void UpDateStatusById(UserDto user)
        {
            this.userDal.UpDateStatusById(mapper.Map<User>(user));
        }

        public void UpDateType(int id, int typeId)
        {
            this.userDal.UpDateType(id, typeId);
        }

        public void UpDateUser(FullUser user)
        {
            // ללא קשרי גומלין UserDto  מקבלת 
            //שולחת לפונקציה שמקבלת עם קשרי גומלין
            this.userDal.UpDateUser(mapper.Map<User>(user));
        }

        public UserDto ForgetPassword(string oneUsePassword, string email)
        {
            return mapper.Map<UserDto>(this.userDal.ForgetPassword(oneUsePassword, email));
        }

        public void SendEmailOnly(string to, string name, string subject)
        {
            User user = this.userDal.GetAllUsers().FirstOrDefault(x => x.Email == to);


            if (user != null)
            {
                //יצירת סיסמא
                string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                StringBuilder oneUsePass = new StringBuilder();
                int len = 10;
                Random rnd = new Random();
                while (0 < len--)
                {
                    oneUsePass.Append(valid[rnd.Next(valid.Length)]);
                }

                //var email = new MimeMessage();
                //email.From.Add(new MailboxAddress("SmartLists", "smartlists@gmaill.com"));
                //email.To.Add(new MailboxAddress(name, to));

                //email.Subject = subject;
                //email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
                //{
                //    Text = text
                //};


                //using (var s = new SmtpClient())
                //{
                //    s.CheckCertificateRevocation = false;
                //    s.Connect("smtp.gmail.com", 587, false);
                //    s.Authenticate("smartlists@gmail.com", "eyklmwlvazmscpxn");
                //    s.Send(email);
                //    s.Disconnect(true);
                //}

                //שמירת הסיסמא החדשה אצל הבן אדם
                user.OneTimePassword = oneUsePass.ToString();
            }

        }

    }
}

