using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Dal
{
    public class AttractionTypeDal : IAttractionTypeDal
    {
        private readonly ElishevaMHadasBListsTripContext ElishevaMHadasBListsTripContext;
        public AttractionTypeDal(ElishevaMHadasBListsTripContext context)
        {
            this.ElishevaMHadasBListsTripContext = context;
        }

        public List<AttractionType> GetAll()
        {
            return this.ElishevaMHadasBListsTripContext.AttractionTypes.ToList();
        }
    }
}
