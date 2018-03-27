using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repository
{
   
   public class recRepository : IrecRepository
   {
       private db_the_recsEntities _context;

       public recRepository()
       {
           _context = new db_the_recsEntities();
       }

       public tb_the_recs GetRecsByValue(string recValue)
       {
           tb_the_recs rec = (from p in _context.tb_the_recs
                              where p.rec == recValue
                              select p).Single();

           return rec;
       }
   }
}
