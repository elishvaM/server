using Entity;
using Microsoft.EntityFrameworkCore;
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
        public TripList Add(TripList tripList)
        {
            tripList.AttractionLists = null;
            tripList.AddingDate = DateTime.Now;
            ElishevaMHadasBListsTripContext.TripLists.Add(tripList);
            ElishevaMHadasBListsTripContext.SaveChanges();
            return tripList;
        }

        public void Delete(TripList tripList)
        {
            ElishevaMHadasBListsTripContext.TripLists.Remove(tripList);
            ElishevaMHadasBListsTripContext.SaveChanges();
        }

        public List<TripList> GetAll(int userId)
        {
            return ElishevaMHadasBListsTripContext.TripLists.Where(x => x.UserId == userId)
                .Include(x => x.AttractionLists).ThenInclude(x=>x.Attraction)
                 .ToList();
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
