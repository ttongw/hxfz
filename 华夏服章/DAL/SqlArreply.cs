using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlArreply:IArreply
    {
        HanFuEntities db = DbContextFactory.CreateDbContext();

        public IEnumerable<Arreply> GetArreply()
        {
            var arr = db.Arreply.ToList();
            return arr;
        }

        public Arreply GetArreplyById(int? id)
        {
            var arr = db.Arreply.Find(id);
            return arr;
        }
    }
}
