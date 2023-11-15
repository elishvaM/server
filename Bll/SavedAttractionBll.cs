using AutoMapper;
using Dal;
using Dto;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class SavedAttractionBll : ISavedAttractionBll
    {
        private readonly ISavedAttractionDal savedAttractionDal;
        private readonly IMapper mapper;
        public SavedAttractionBll(ISavedAttractionDal savedAttractionDal, IMapper mapper)
        {
            this.savedAttractionDal = savedAttractionDal;
            this.mapper = mapper;
        }

        public void AddLovedAttraction(SavedAttractionDto lovedAttraction)
        {
            ///??? var or object מה ההבדל
            savedAttractionDal.AddLovedAttraction(mapper.Map<SavedAttraction>(lovedAttraction));
        }

        public List<SavedAttractionDto> GetSavedAttractionByUserId(int userId)
        {
            userId = 8;
            Console.WriteLine("PPP");
            Console.WriteLine(userId);
            return mapper.Map<List<SavedAttractionDto>>(savedAttractionDal.GetSavedAttractionByUserId(userId));
        }

        public void RemoveLovedAttraction(SavedAttractionDto lovedaAttraction)
        {
            savedAttractionDal.RemoveLovedAttraction(mapper.Map<SavedAttraction>(lovedaAttraction));
        }
    }
}
