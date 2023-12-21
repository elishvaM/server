using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Dal
{
    public interface ITripListDal
    {
        List<TripList> GetAll();
        void Add(TripList tripList);
        void Update(TripList tripList);
        void Delete(TripList tripList);
    }
}
