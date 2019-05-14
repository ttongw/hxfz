using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class SqlPreply : IPreply
    {
        HanFuEntities db = DbContextFactory.CreateDbContext();

        public IEnumerable<Preply> GetPreply()
        {
            var preply = db.Preply.ToList();
            return preply;
        }

        public Preply GetPreplyById(int? id)
        {
            Preply pre = db.Preply.Find(id);
            return pre;
        }
    }
}
