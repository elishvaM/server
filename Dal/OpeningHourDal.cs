using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Dal
{
    public class OpeningHourDal : IOpeningHourDal
    {
        private readonly ElishevaMHadasBListsTripContext ElishevaMHadasBListsTripContext;
        public OpeningHourDal(ElishevaMHadasBListsTripContext context)
        {
            this.ElishevaMHadasBListsTripContext = context;
        }

        public void Add(OpeningHour openingHour)
        {
            ///??? איך יהיה אייידי של אטרקציה לפני שהיא נוספה
            this.ElishevaMHadasBListsTripContext.OpeningHours.Add(openingHour);
            this.ElishevaMHadasBListsTripContext.SaveChanges();
        }



        public List<OpeningHour> Get(int id)
        {
            return this.ElishevaMHadasBListsTripContext.OpeningHours.Where(o => o.AttractionId == id).ToList();
        }

        public OpeningHour Get(Attraction attraction)
        {
            return this.ElishevaMHadasBListsTripContext.OpeningHours.FirstOrDefault(o => o.AttractionId == attraction.Id);
        }

        public OpeningHour Update(OpeningHour openingHour)
        {
            OpeningHour found = this.ElishevaMHadasBListsTripContext.OpeningHours
                .FirstOrDefault(o => o.Id == openingHour.Id);
            TimeSpan time = new TimeSpan(24, 0, 0);
            if (this.ElishevaMHadasBListsTripContext.OpeningHours
                .Any(o => (o.Id != openingHour.Id && openingHour.Day == o.Day && openingHour.AttractionId == o.AttractionId && openingHour.OpeningHour1 == o.OpeningHour1) ||
                (openingHour.OpeningHour1 > openingHour.ClosingHour) ||
                (o.Id == openingHour.Id && openingHour.Day == o.Day && openingHour.AttractionId == o.AttractionId && openingHour.OpeningHour1 == o.OpeningHour1)))
            {
                return null;
            }
            if (found != null)
            {
                found.Day = openingHour.Day;
                if (openingHour.IsOpening)
                {
                    if (openingHour.OpeningHour1 != null)
                        found.OpeningHour1 = openingHour.OpeningHour1;
                    if (openingHour.ClosingHour != null)
                        found.ClosingHour = openingHour.ClosingHour;
                }
                found.IsOpening = openingHour.IsOpening;
                this.ElishevaMHadasBListsTripContext.SaveChanges();
                return found;
            }
            else
            {
                this.ElishevaMHadasBListsTripContext.OpeningHours.Add
                    (openingHour);
                ;
                this.ElishevaMHadasBListsTripContext.SaveChanges();
                return openingHour;
            }
        }

        public void Delete(OpeningHour openingHour)
        {
            OpeningHour o = this.ElishevaMHadasBListsTripContext.OpeningHours.FirstOrDefault(x => x.Id == openingHour.Id);
            this.ElishevaMHadasBListsTripContext.OpeningHours.Remove(o);
            this.ElishevaMHadasBListsTripContext.SaveChanges(); 
        }
    }
}
