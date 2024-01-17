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
        public List<keyCount> GetAllAttractionListProductByTripListIdId(int tripListId)
        {
            //return ElishevaMHadasBListsTripContext.AttractionListProducts.Where(x => x.AttractionList.TripList.Id == tripListId)
            //    .Include(x => x.Product).ThenInclude(x => x.StorageType)
            //    .Include(x => x.Product).ThenInclude(x => x.ProductType)
            //    .GroupBy(x => x.Product).Select(y =>
            //    new keyCount() { Key = y.Key.Name,
            //        Product = y.Key, Sum = y.Key.IsDuplicated ? y.Sum(x => x.Amount) : y.ToList().Max(x => x.Amount)

            //    }).ToList();


            var a = ElishevaMHadasBListsTripContext.AttractionListProducts.Where(x => x.AttractionList.TripList.Id == tripListId)
            .Include(x => x.Product).ThenInclude(x => x.StorageType)
            .Include(x => x.Product).ThenInclude(x => x.ProductType)
            .GroupBy(x => x.Product)
            .ToList()//need it bacause just like this it get the include()
            .Select(y=>y)
            .ToList();
            List<keyCount> all = new List<keyCount>(); 
            foreach (var y in a)
            {
                all.Add(new keyCount()
                {
                    Key = y.Key.Name,
                    Product = y.Key,
                    Sum = y.Key.IsDuplicated ? y.Sum(x => x.Amount) : y.ToList().Max(x => x.Amount)
                });
            };
            return all;


        }
    }
    public class keyCount
    {
        public string Key { get; set; }
        public int Sum { get; set; }
        public Product Product { get; set; }
    }

}
