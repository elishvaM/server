using AutoMapper;
using Dal;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class SavedAttractionBll:ISavedAttractionBll
    {
        private readonly ISavedAttractionDal savedAttractionDal;
        private readonly IMapper mapper;
        public SavedAttractionBll(ISavedAttractionDal savedAttractionDal, IMapper mapper)
        {
            this.savedAttractionDal = savedAttractionDal;
            this.mapper = mapper;
        }
        public List<SavedAttractionDto> GetSavedAttractionByUserId(int userId)
        {
            userId = 8;
            Console.WriteLine("PPP");
            Console.WriteLine(userId);
            return mapper.Map<List<SavedAttractionDto>>(savedAttractionDal.GetSavedAttractionByUserId(userId));
        }

    }
}
