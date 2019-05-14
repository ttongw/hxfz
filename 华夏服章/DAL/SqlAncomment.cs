using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlAncomment:IAncomment
    {
        HanFuEntities db = DbContextFactory.CreateDbContext();

        public IEnumerable<Ancomment> GetAncomment()
        {
            var anc = db.Ancomment.ToList();
            return anc;
        }

        public Ancomment GetAncommentById(int? id)
        {
            Ancomment ancomment = db.Ancomment.Find(id);
            return ancomment;
        }

        public IQueryable<Anreply> GetAnreplyByAncommentId(int id)
        {
            var anreply = db.Anreply.Include("Ancomment").Where(c => c.AncomId == id);
            return anreply;
        }
    }
}
