using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IAttractionListProductDal
    {
        List<AttractionListProduct> GetByAttractionListId(int attractionId);
        void Delete(AttractionListProduct attractionListProduct);
        void Add(AttractionListProduct attractionListProduct);
    }
}
