using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
namespace Bll
{
    public interface IOpeningHourBll
    {
        public List<OpeningHourDto> Get(int id);
        public OpeningHourDto Get(AttractionDto attraction);
        public void Update(OpeningHourDto openingHour);
    }
}
