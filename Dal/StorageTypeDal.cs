using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class StorageTypeDal:IStorageTypeDal
    {
        private readonly ElishevaMHadasBListsTripContext ElishevaMHadasBListsTripContext;
        public StorageTypeDal(ElishevaMHadasBListsTripContext context)
        {
            this.ElishevaMHadasBListsTripContext = context;
        }
        public List<StorageType> GetAll()
        {
            return ElishevaMHadasBListsTripContext.StorageTypes.ToList();
        }
    }
}
