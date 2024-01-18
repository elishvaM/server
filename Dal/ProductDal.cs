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

            return this.ElishevaMHadasBListsTripContext.Products.Where(x=>x.Status==true).Include(x=>x.StorageType)
                .Include(x=>x.ProductType).ToList();
        }
        public int AddProduct(Product p)
        {
            this.ElishevaMHadasBListsTripContext.Products.Add(p);            
            this.ElishevaMHadasBListsTripContext.SaveChanges();//מכניס את הנתונים כולל התז החדש לאוביקט p
            return p.Id; 
         }

        public void Delete(int id)
        {
            Product p = ElishevaMHadasBListsTripContext.Products.FirstOrDefault(x => x.Id == id);
            if(p != null) { p.Status = false; }
            this.ElishevaMHadasBListsTripContext.SaveChanges();
        }

        public void Update(Product p)
        {
            Product p2 = ElishevaMHadasBListsTripContext.Products.FirstOrDefault(x => x.Id == p.Id);
            if(p2!= null) {
                p2.Status = p.Status;
                p2.StorageTypeId = p.StorageTypeId;
                p2.ProductTypeId = p.ProductTypeId;
                p2.IsNeedAssurants = p.IsNeedAssurants;
                p2.IsConfirm = p.IsConfirm;
                p2.IsImgConfirm = p.IsImgConfirm;
                p2.Name = p.Name;
                p2.IsDuplicated = p.IsDuplicated;
                p2.Img = p.Img;
                //p2.UserId = p.UserId;
                this.ElishevaMHadasBListsTripContext.SaveChanges();
            }
        }
    }
}
