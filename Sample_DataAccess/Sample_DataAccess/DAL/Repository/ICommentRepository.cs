using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repository
{
    public interface ICommentRepository
    {
        List<string> GetCommentbyRecValue(string recValue);
    }
}
