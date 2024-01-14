using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Dal
{
    public class PersonStateDal:IPersonStateDal
    {
        private readonly ElishevaMHadasBListsTripContext ElishevaMHadasBListsTripContext;
        public PersonStateDal(ElishevaMHadasBListsTripContext context)
        {
            this.ElishevaMHadasBListsTripContext = context;
        }
        public List<PersonState> GetAll()
        {
            return this.ElishevaMHadasBListsTripContext.PersonStates.ToList();
        }
    }
}
