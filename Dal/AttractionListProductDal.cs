using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class AttractionListProductDal : IAttractionListProductDal
    {
        private readonly ElishevaMHadasBListsTripContext ElishevaMHadasBListsTripContext;
        public AttractionListProductDal(ElishevaMHadasBListsTripContext context)
        {
            ElishevaMHadasBListsTripContext = context;
        }

        public void Add(AttractionListProduct attractionListProduct)
        {
            ElishevaMHadasBListsTripContext.AttractionListProducts.Add(attractionListProduct);
            ElishevaMHadasBListsTripContext.SaveChanges();
            //return attractionListProduct;
        }

        public void Delete(AttractionListProduct attractionListProduct)
        {
            ElishevaMHadasBListsTripContext.AttractionListProducts.Remove(attractionListProduct);
            ElishevaMHadasBListsTripContext.SaveChanges();
        }

        public List<AttractionListProduct> GetByAttractionListId(int attractionListId)
        {
            return ElishevaMHadasBListsTripContext.AttractionListProducts.Where(x=> x.AttractionListId == attractionListId)
                .Include(x=>x.Product).ToList();
        }
    }
}
