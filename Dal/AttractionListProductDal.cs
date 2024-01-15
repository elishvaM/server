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

        public AttractionListProduct Add(AttractionListProduct attractionListProduct)
        {
            ElishevaMHadasBListsTripContext.AttractionListProducts.Add(attractionListProduct);
            ElishevaMHadasBListsTripContext.SaveChanges();
            return attractionListProduct;
        }

        public List<AttractionListProduct> AddList(List<AttractionListProduct> attractionListProduct)
        {
            ElishevaMHadasBListsTripContext.AttractionListProducts.AddRange(attractionListProduct);
            ElishevaMHadasBListsTripContext.SaveChanges();
            return attractionListProduct;
        }

        public void Delete(int productId, int attractionListId)
        {
            AttractionListProduct x = ElishevaMHadasBListsTripContext.AttractionListProducts.FirstOrDefault(x => x.AttractionListId == attractionListId && x.ProductId == productId);
            ElishevaMHadasBListsTripContext.AttractionListProducts.Remove(x);
            ElishevaMHadasBListsTripContext.SaveChanges();
        }

        public List<AttractionListProduct> GetByAttractionListId(int attractionListId)
        {
            return ElishevaMHadasBListsTripContext.AttractionListProducts.Where(x=> x.AttractionListId == attractionListId)
                .Include(x => x.Product).ThenInclude(x => x.StorageType)
                .Include(x => x.Product).ThenInclude(x => x.ProductType)
                .ToList();
        }
    }
}
