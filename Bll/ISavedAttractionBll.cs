using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public interface ISavedAttractionBll
    {
        List<SavedAttractionDto> GetSavedAttractionByUserId(int userId);
    }
}
