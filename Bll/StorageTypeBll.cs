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
    public class StorageTypeBll:IStorageTypeBll
    {
        private readonly IStorageTypeDal storageTypeDal;
        private readonly IMapper mapper;
        public StorageTypeBll(IStorageTypeDal storageTypeDal, IMapper mapper)
        {
            this.storageTypeDal = storageTypeDal;
            this.mapper = mapper;
        }

        public List<StorageTypeDto> GetAll()
        {
            return mapper.Map<List<StorageTypeDto>>(storageTypeDal.GetAll());
        }
    }
}
