using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Dal
{
    public interface IOpeningHourDal
    {
        public OpeningHour Get(Attraction attraction);
        public List<OpeningHour> Get(int id);
        public OpeningHour Update(OpeningHour openingHour);
        public void Add(OpeningHour openingHour);
        public bool CheckIsValid(string openingHour,string closingHour);
    }
}
