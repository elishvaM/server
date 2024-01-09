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

        void Delete(AttractionListProductDto AttractionListProduct);
        void Add(AttractionListProductDto attractionListProduct);
    }
}
