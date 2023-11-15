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

        public void AddLovedAttraction(SavedAttraction lovedAttraction)
        {
            ElishevaMHadasBListsTripContext.SavedAttractions.Add(lovedAttraction);
            this.ElishevaMHadasBListsTripContext.SaveChanges();
        }

        public List<SavedAttraction> GetSavedAttractionByUserId(int userId)
        {
            return ElishevaMHadasBListsTripContext.SavedAttractions.Where(x => x.UserId == userId).ToList();
        }

        public void RemoveLovedAttraction(SavedAttraction lovedAttractionId)
        {
            SavedAttraction foundAttraction = ElishevaMHadasBListsTripContext.SavedAttractions.FirstOrDefault(x =>
                                              x.AttractionId == lovedAttractionId.AttractionId && x.UserId == lovedAttractionId.UserId);
            ElishevaMHadasBListsTripContext.SavedAttractions.Remove(foundAttraction);
            ElishevaMHadasBListsTripContext.SaveChanges();
        }
    }
}
