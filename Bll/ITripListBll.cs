using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
namespace Bll
{
    public interface ITripListBll
    {
        List<TripListDto> GetAll(int userId);

        TripListDto Add(TripListDto tripList);

        void Update(TripListDto tripList);

        void Delete(TripListDto tripList);

        void SendEmailOnly(string to, string subject);

    }
}
