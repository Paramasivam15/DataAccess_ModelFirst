using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;

namespace DAL.Repository
{
    public class CommentRepository
    {
         private db_the_recsEntities _context;

         public CommentRepository()
         {
             _context = new db_the_recsEntities();
         }

        public List<string> GetCommentbyRecValue(string recValue)
        {
            ObjectQuery<tb_the_comments> CommentObjectQry = _context.tb_the_comments.Include("tb_the_recs");
            List<string> commentList = new List<string>();
            commentList = CommentObjectQry.Where(x=>x.tb_the_recs.rec.Equals(recValue)).Select(x=>x.comments).ToList();
            return commentList;
        }
    }
}
