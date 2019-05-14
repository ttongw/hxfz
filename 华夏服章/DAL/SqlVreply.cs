using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class SqlVreply:IVreply
    {
        HanFuEntities db = DbContextFactory.CreateDbContext();

        public IEnumerable<Vreply> GetVreply()
        {
            var vre = db.Vreply.ToList();
            return vre;
        }

        public Vreply GetVreplyById(int? id)
        {
            var vre = db.Vreply.Find(id);
            return vre;
        }
    }
}
