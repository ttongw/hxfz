using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlPcomment:IPcomment
    {
        HanFuEntities db = DbContextFactory.CreateDbContext();

        public IEnumerable<Pcomment> GetAncomment()
        {
            var pc = db.Pcomment.ToList();
            return pc;
        }

        public Pcomment GetAncommentById(int? id)
        {
            Pcomment pcomment = db.Pcomment.Find(id);
            return pcomment;
        }

        public IQueryable<Preply> GetPreplyByPcommentId(int id)
        {
            var preply = db.Preply.Include("Pcomment").Where(c => c.PcomId == id);
            return preply;
        }
    }
}
