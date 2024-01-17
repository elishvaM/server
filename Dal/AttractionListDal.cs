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

        public List<AttractionList> GetAttractionListByAttractionId(int attractionId, int myattractionList)
        {
            return ElishevaMHadasBListsTripContext.AttractionLists.Where(x=>x.AttractionId == attractionId && x.Id!= myattractionList)
                .Include(x=>x.AttractionListProducts).ThenInclude(x=>x.Product).ThenInclude(x=>x.StorageType)
                .Include(x=>x.AttractionListProducts).ThenInclude(x=>x.Product).ThenInclude(x=>x.ProductType)
                .ToList();
        }
        public List<AttractionList> GetAttractionListByUserId(int userId)
        {
            return ElishevaMHadasBListsTripContext.AttractionLists.ToList();
        }

    }
}
