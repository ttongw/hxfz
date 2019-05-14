using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlVcomment:IVcomment
    {
        HanFuEntities db =  DbContextFactory.CreateDbContext();

        public IEnumerable<Vcomment> GetVcomment()
        {
            var vc = db.Vcomment.ToList();
            return vc;
        }

        public Vcomment GetVcommentById(int? id)
        {
            Vcomment vcomment = db.Vcomment.Find(id);
            return vcomment;
        }

        public IQueryable<Vreply> GetVreplyByVcommentId(int id)
        {
            var vreply = db.Vreply.Include("Vcomment").Where(c => c.VcomId == id);
            return vreply;
        }
    }
}
