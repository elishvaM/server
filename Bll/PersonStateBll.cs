using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using AutoMapper;
using Dto;

namespace Bll
{
    public class PersonStateBll : IPersonStateBll
    {
        private readonly IPersonStateDal personStateDal;
        private readonly IMapper mapper;
        public PersonStateBll(IPersonStateDal personStateDal, IMapper mapper)
        {
            this.personStateDal = personStateDal;
            this.mapper = mapper;
        }

        public List<PersonStateDto> GetAll()
        {
            return mapper.Map<List<PersonStateDto>>(personStateDal.GetAll());
        }
    }
}
