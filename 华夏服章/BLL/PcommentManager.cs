using DALFactory;
using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PcommentManager
    {
        IPcomment ipcomment = DataAccess.CreatePcomment();
        public IEnumerable<Pcomment> GetAncomment()
        {
            var pc = ipcomment.GetAncomment();
            return pc;
        }

        public Pcomment GetAncommentById(int? id)
        {
            Pcomment pcomment = ipcomment.GetAncommentById(id);
            return pcomment;
        }

        public IQueryable<Preply> GetPreplyByPcommentId(int id)
        {
            var preply = ipcomment.GetPreplyByPcommentId(id);
            return preply;
        }
    }
}
