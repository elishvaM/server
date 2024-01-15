using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ProductDal:IProductDal
    {
        private readonly ElishevaMHadasBListsTripContext ElishevaMHadasBListsTripContext;
        public ProductDal(ElishevaMHadasBListsTripContext context)
        {
            this.ElishevaMHadasBListsTripContext = context;
        }
        public List<Product> GetAllProducts()
        {

            return this.ElishevaMHadasBListsTripContext.Products.Include(x=>x.StorageType)
                .Include(x=>x.ProductType).ToList();
        }
        public int AddProduct(Product p)
        {
            this.ElishevaMHadasBListsTripContext.Products.Add(p);
            
            this.ElishevaMHadasBListsTripContext.SaveChanges();//מכניס את הנתונים כולל התז החדש לאוביקט p

            return p.Id; 
         }
    }
}
