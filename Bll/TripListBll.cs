using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using AutoMapper;
using Entity;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using MailKit.Net.Smtp;
using MimeKit;
namespace Bll
{
    public class TripListBll : ITripListBll
    {
        private readonly ITripListDal tripListDal;
        private readonly IMapper mapper;
        public TripListBll(ITripListDal tripListDal, IMapper mapper)
        {
            this.tripListDal = tripListDal;
            this.mapper = mapper;
        }
        public TripListDto Add(TripListDto tripList)
        {
            return mapper.Map<TripListDto>(this.tripListDal.Add(mapper.Map<TripList>(tripList)));
        }

        public void Delete(TripListDto tripList)
        {
            this.tripListDal.Delete(mapper.Map<TripList>(tripList));
        }

        public List<TripListDto> GetAll(int userId)
        {

            return mapper.Map<List<TripListDto>>(this.tripListDal.GetAll(userId));
        }

        public void Update(TripListDto tripList)
        {
            this.tripListDal.Update(mapper.Map<TripList>(tripList));
        }
        public void SendEmailOnly(string to, string subject)
        {
            //to -מייל של מחובר מהלקוח
            //subject- שולחים ידנית פשוט כמו רשימות הטיול
            // User user = this.userDal.GetAllUsers().FirstOrDefault(x => x.Email.ToLower() == to.ToLower());
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("SmartLists", "smartlists@gmail.com"));
            email.To.Add(new MailboxAddress("אני", to));
           // email.To.Add(new MailboxAddress(user.Name, to));

            email.Subject = subject;
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = $"<div><h1>ץיכף תקבל את כל הרשימות שלך<h1></div>"
            };

            using (var s = new SmtpClient())
            {
                s.CheckCertificateRevocation = false;
                s.Connect("smtp.gmail.com", 587, false);
                s.Authenticate("smartlists.com@gmail.com", "yohbofzeutsmsnku");
                s.Send(email);
                s.Disconnect(true);
            }

        }

    }
}
