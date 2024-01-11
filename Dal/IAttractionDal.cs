using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Dal
{
    public interface IAttractionDal
    {
        List<Attraction> GetAll();
        Attraction GetById(int id);
        int Add(Attraction attraction);
        void Update(Attraction attraction);
        void UpdateStatusById(int id);
    }
}
