﻿using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public interface IAttractionListBll
    {
        List<AttractionListDto> GetAttractionListByUserId(int userId);
        List<AttractionListDto> GetAttractionListByAttractionId(int attractionId, int myattractionList);
        PostAttractionList Add(PostAttractionList attractionList);
    }
}
