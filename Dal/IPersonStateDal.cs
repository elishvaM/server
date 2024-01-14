using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Dal
{
    public interface IPersonStateDal
    {
        public List<PersonState> GetAll();
    }
}
