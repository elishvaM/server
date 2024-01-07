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

        public bool AddLovedAttraction(SavedAttraction lovedAttraction)
        {

            List<SavedAttraction> foundAttraction = ElishevaMHadasBListsTripContext.SavedAttractions.Where(x =>
                                            x.AttractionId == lovedAttraction.AttractionId && x.UserId == lovedAttraction.UserId).ToList();
            if (!foundAttraction.Any())
            {

                ElishevaMHadasBListsTripContext.SavedAttractions.Add(lovedAttraction);
                ElishevaMHadasBListsTripContext.SaveChanges();
                return true;

            }
            else
            {
                ElishevaMHadasBListsTripContext.SavedAttractions.RemoveRange(foundAttraction);
                ElishevaMHadasBListsTripContext.SaveChanges();

                return false;

            }
        }

        public List<SavedAttraction> GetSavedAttractionByUserId(int userId)
        {
            return ElishevaMHadasBListsTripContext.SavedAttractions.Where(x => x.UserId == userId).ToList();
        }


    }
}
