using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Microsoft.EntityFrameworkCore;
namespace Dal
{
    public class AttractionDal : IAttractionDal
    {
        //accsse to db
        private readonly ElishevaMHadasBListsTripContext ElishevaMHadasBListsTripContext;
        public AttractionDal(ElishevaMHadasBListsTripContext context)
        {
            this.ElishevaMHadasBListsTripContext = context;
        }
        public void Add(Attraction attraction)
        {
            this.ElishevaMHadasBListsTripContext.Attractions.Add(attraction);
        }
        public List<Attraction> GetAll()
        {
           return this.ElishevaMHadasBListsTripContext.Attractions.Include(x=>x.Address).OrderBy(x=>x.Address.Number).ToList();
        }

        public Attraction GetById(int id)
        {
            return this.ElishevaMHadasBListsTripContext.Attractions.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Attraction attraction)
        {
            var a = this.ElishevaMHadasBListsTripContext.Attractions.FirstOrDefault(x => x.Id == attraction.Id);
            a.Name = attraction.Name;
            a.Desc = attraction.Desc;
            a.Img = attraction.Img;
            a.TypeId = attraction.TypeId;
            a.WebsiteAddress = attraction.WebsiteAddress;
            a.CountryId = attraction.CountryId;
            a.IsConfirm = false;
        }
        public void UpdateStatusById(int id)
        {
            var a = this.ElishevaMHadasBListsTripContext.Attractions.FirstOrDefault(x => x.Id == id);
            a.IsConfirm = !a.IsConfirm;
        }
    }
}
