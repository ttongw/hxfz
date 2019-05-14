using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlAnreply:IAnreply
    {
        HanFuEntities db = DbContextFactory.CreateDbContext();

        public IEnumerable<Anreply> GetAnreply()
        {
            var anr = db.Anreply.ToList();
            return anr;
        }

        public Anreply GetAnreplyById(int? id)
        {
            var anr = db.Anreply.Find(id);
            return anr;
        }
    }
}
