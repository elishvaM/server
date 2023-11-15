using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace Dal
{
    public class SavedAttractionDal : ISavedAttractionDal
    {
        private readonly ElishevaMHadasBListsTripContext ElishevaMHadasBListsTripContext;
        public SavedAttractionDal(ElishevaMHadasBListsTripContext context)
        {
            this.ElishevaMHadasBListsTripContext = context;
        }
        public List<SavedAttraction> GetSavedAttractionByUserId(int userId)
        {
            return ElishevaMHadasBListsTripContext.SavedAttractions.Where(x => x.UserId == userId).ToList(); 
        }
    }
}
