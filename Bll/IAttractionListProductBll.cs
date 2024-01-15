using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public interface IAttractionListProductBll
    {
        List<AttractionListProductDto> GetByAttractionListId(int attractionListId);
        void Delete(int productId, int attractionListId);
        AttractionListProductDto Add(AttractionListProductDto attractionListProduct);
        List<AttractionListProductDto> AddList(List<AttractionListProductDto> attractionListProduct);
    }
}
