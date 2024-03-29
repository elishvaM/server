﻿using Bll;
using Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gui.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttractionListController : ControllerBase
    {
        private readonly IAttractionListBll attractionListBll;
        public AttractionListController(IAttractionListBll attractionListBll)
        {
            this.attractionListBll = attractionListBll;
        }

        [HttpGet("/api/[controller]/GetSAttractionListByAttractionId/{attractionId}/{myattractionlist}")]
        public List<AttractionListDto> GetAttractionListByAttractionId(int attractionId, int myattractionList)
        {
            return attractionListBll.GetAttractionListByAttractionId(attractionId, myattractionList);
        }

        [HttpGet("/api/[controller]/GetSAttractionListByUserId")]
        public List<AttractionListDto> GetAttractionListByUserId(int userId)
        {
            return attractionListBll.GetAttractionListByUserId(userId);
        }

        // POST api/<AttractionListController>
        [HttpPost("/api/[controller]/Add")]
        public PostAttractionList Add([FromBody] PostAttractionList attractionList)
        {
            attractionList= attractionListBll.Add(attractionList);
            return attractionList;
        }

        // PUT api/<AttractionListController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AttractionListController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
