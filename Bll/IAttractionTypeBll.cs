using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Entity;
using AutoMapper;
using Dto;
namespace Bll
{
    public interface IAttractionTypeBll
    {
        List<AttractionTypeDto> GetAll();
    }
}
