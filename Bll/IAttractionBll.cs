using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
namespace Bll
{
    public interface IAttractionBll
    {
        //List<AttractionDto> GetAll();
       object GetAll();
        AttractionDto GetById(int id);
        void Add(AttractionDto attraction);
        void Update(AttractionDto attraction);
        void UpdateStatusById(int id);
    }
}
