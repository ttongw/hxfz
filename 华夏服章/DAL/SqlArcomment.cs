using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlArcomment:IArcomment
    {
        HanFuEntities db = DbContextFactory.CreateDbContext();

        public IEnumerable<Arcomment> GetArcomment()
        {
            var arc = db.Arcomment.ToList();
            return arc;
        }

        public Arcomment GetArcommentById(int? id)
        {
            Arcomment arcomment = db.Arcomment.Find(id);
            return arcomment;
        }

        public IQueryable<Arreply> GetArreplyByArcommentId(int id)
        {
            var arreply = db.Arreply.Include("Arcomment").Where(c => c.ArcomId == id);
            return arreply;
        }
    }
}
