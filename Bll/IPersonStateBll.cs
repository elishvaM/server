﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
namespace Bll
{
    public interface IPersonStateBll
    {
        List<PersonStateDto> GetAll();
    }
}
