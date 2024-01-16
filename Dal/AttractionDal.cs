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
        public Attraction Add(Attraction attraction)
        {
            attraction.Status = true;
            this.ElishevaMHadasBListsTripContext.Attractions.Add(attraction);
            ElishevaMHadasBListsTripContext.SaveChanges();
            return attraction;
        }
        public List<Attraction> GetAll()
        {
           return this.ElishevaMHadasBListsTripContext.Attractions.Include(x=>x.Address).Include(x=>x.Type).Include(x=>x.PersonState)
                .OrderBy(x=>x.Address.Number).ToList();
        }

        public Attraction GetById(int id)
        {
            return this.ElishevaMHadasBListsTripContext.Attractions.FirstOrDefault(x => x.Id == id);
        }

        public List<Attraction> GetFavorites()
        {
            return this.ElishevaMHadasBListsTripContext.Attractions.Include(x => x.Address).OrderByDescending(x =>x.AttractionLists.Count()).Take(2).ToList();
        }

        public void Update(Attraction attraction)
        {

            //this.ElishevaMHadasBListsTripContext.AttractionListProducts
            //    .Where(x =>  x.AttractionList.ExitDate.Date == DateTime.Today)
            //    .GroupBy(x => x.Product).Select(y =>
            //    {
            //        string key = y.Key.Name;
            //        int sum =y.Key.IsDuplicated?y.Sum(x=>x.Amount): y.ToList().Max(x => x.Amount);
            //    //  return 

            //    });

            var a = this.ElishevaMHadasBListsTripContext.Attractions.FirstOrDefault(x => x.Id == attraction.Id);
            a.Name = attraction.Name;
            a.Desc = attraction.Desc;
            a.Img = attraction.Img;
            a.Img2= attraction.Img2;
            a.Img3= attraction.Img3;    
            a.Type = attraction.Type;
            a.WebsiteAddress = attraction.WebsiteAddress;
            a.Address = attraction.Address;
            a.PersonState = attraction.PersonState;
            a.IsConfirm = a.IsConfirm;
            ElishevaMHadasBListsTripContext.SaveChanges();
        }
        public void UpdateStatusById(int id)
        {
            var a = this.ElishevaMHadasBListsTripContext.Attractions.FirstOrDefault(x => x.Id == id);
            a.IsConfirm = !a.IsConfirm;
        }
 
    }
}
