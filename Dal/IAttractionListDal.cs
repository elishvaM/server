﻿using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IAttractionListDal
    {
        List<AttractionList> GetAttractionListByUserId(int userId);
    }
}
