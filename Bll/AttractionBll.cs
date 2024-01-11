using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;
using AutoMapper;
using Dto;
namespace Bll
{
    public class AttractionBll : IAttractionBll
    {
        // entity בשכבת הדל הפונקציות קבלו אובייקט מסוג       
        // dto ואילו כאן הפונקציות יקבלו אובייקט מסוג 

        //בשכבת הדל קבלנו ועבדנו עם אובייקטים עם קשרי גומלין
        // dto אנו מקבלות ועובדות עם אובייקטים לא קשרי גומלין  bll בשכבת 
        //ולכן הצטרכנו להמירם
        private readonly IAttractionDal attractionDal;
        private readonly IMapper mapper;
        public AttractionBll(IAttractionDal attractionDal, IMapper mapper)
        {
            this.attractionDal = attractionDal;
            this.mapper = mapper;
        }
        public int Add(AttractionDto attraction)
        {
            return this.attractionDal.Add(mapper.Map<Attraction>(attraction));
        }
        public List<AttractionDto> GetAll()
        {
            return mapper.Map<List<AttractionDto>>(this.attractionDal.GetAll());
        }
        public AttractionDto GetById(int id)
        {
            return mapper.Map<AttractionDto>(this.attractionDal.GetById(id));
            //            ne.CityName = at.Address.Land; 

        }
        public void Update(AttractionDto attraction)
        {
            this.attractionDal.Update(mapper.Map<Attraction>(attraction));
        }

        public void UpdateStatusById(int id)
        {
            this.attractionDal.UpdateStatusById(id);
        }
    }
}
