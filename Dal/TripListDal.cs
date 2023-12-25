using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class TripListDal : ITripListDal
    {
        private readonly ElishevaMHadasBListsTripContext ElishevaMHadasBListsTripContext;
        public TripListDal(ElishevaMHadasBListsTripContext context)
        {
            this.ElishevaMHadasBListsTripContext = context;
        }
        public void Add(TripList tripList)
        {
            ElishevaMHadasBListsTripContext.TripLists.Add(tripList);
            ElishevaMHadasBListsTripContext.SaveChanges();
        }

        public void Delete(TripList tripList)
        {
            ElishevaMHadasBListsTripContext.TripLists.Remove(tripList);
            ElishevaMHadasBListsTripContext.SaveChanges();
        }

        public List<TripList> GetAll(int userId)
        {
            return ElishevaMHadasBListsTripContext.TripLists.Where(x=>x.UserId == userId).ToList();
        }

        public void Update(TripList tripList)
        {
            var tripListTemp = ElishevaMHadasBListsTripContext.TripLists.FirstOrDefault(x => x.Id == tripList.Id);
            tripListTemp.Name = tripList.Name;
            tripList.BackingDate = tripListTemp.BackingDate;
            tripList.AddingDate = tripListTemp.AddingDate;
            tripList.TravelingDate = tripListTemp.TravelingDate;
            ElishevaMHadasBListsTripContext.SaveChanges();
        }
    }
}
