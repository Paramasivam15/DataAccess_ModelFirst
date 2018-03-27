using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repository
{
    interface IrecRepository
    {
        tb_the_recs GetRecsByValue(string recValue);
    }
}
