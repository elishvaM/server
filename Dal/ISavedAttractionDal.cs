using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface ISavedAttractionDal
    {
        //?? לשנות לאוביקט
        List<SavedAttraction> GetSavedAttractionByUserId(int userId);
        bool AddLovedAttraction (SavedAttraction lovedAttraction);
    }
}
