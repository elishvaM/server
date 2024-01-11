using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class AttractionListDal:IAttractionListDal
    {
        private readonly ElishevaMHadasBListsTripContext ElishevaMHadasBListsTripContext;
        public AttractionListDal(ElishevaMHadasBListsTripContext context)
        {
            this.ElishevaMHadasBListsTripContext = context;
        }

        public List<AttractionList> GetAttractionListByAttractionId(int attractionId)
        {
            return ElishevaMHadasBListsTripContext.AttractionLists.Where(x=>x.AttractionId == attractionId)
                .Include(x=>x.AttractionListProducts).ThenInclude(x=>x.Product)
                .ToList();
        }

        public List<AttractionList> GetAttractionListByUserId(int userId)
        {
            //Console.WriteLine(ElishevaMHadasBListsTripContext.TripLists.Where(x => x.UserId == userId).ToList()
            // return ElishevaMHadasBListsTripContext.AttractionLists.Where(x => x.Id == userId).ToList();
            //SELECT Id
            //FROM AttractionLists
            //WHERE[a].[Id] = @__userId_0
            var x = ElishevaMHadasBListsTripContext.AttractionLists.
                ToList();
            foreach (var item in x)
            {
                Console.WriteLine(item.Id+" "+item.TripListId);
            }
            return x;
            // ElishevaMHadasBListsTripContext.TripLists.Where(x=>x.UserId == userId).ToList();

        }

    }
}
