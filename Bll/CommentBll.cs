using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Dal;
using Dto;
using Entity;
namespace Bll
{
    public class CommentBll : ICommentBll
    {
        private readonly ICommentDal commentDal;
        private readonly IMapper mapper;
        public CommentBll(ICommentDal commentDal, IMapper mapper)
        {
            this.commentDal = commentDal;
            this.mapper = mapper;
        }
        public void Add(PostComment comment)
        {
            commentDal.Add(mapper.Map<Comment>(comment));
        }

        public void Delete(int commentId)
        {
            commentDal.Delete(commentId);
        }

        public List<CommentDto> GetAll(int attractionId)
        {
            return mapper.Map<List<CommentDto>>(commentDal.GetAll(attractionId));
        }

        public List<CommentDto> GetComplained()
        {
            return mapper.Map<List<CommentDto>>(commentDal.GetComplained());
        }

        public bool UpDateCount(int id, int userId)
        {
            return commentDal.UpDateCount(id, userId);
        }
    }
}
