using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class SqlRsort : IRsort
    {
        HanFuEntities db = DbContextFactory.CreateDbContext();
        public IEnumerable<Relic> GetRelicByRsortId(int id)
        {
            var relic = db.Relic.Include("Rsort").Where(c => c.RsortId == id);
            return relic;
        }

        public IEnumerable<Rsort> GetRsort()
        {
            var rsort = db.Rsort.ToList();
            return rsort;
        }

        public Rsort GetRsortById(int? id)
        {
            Rsort rsort = db.Rsort.Find(id);
            return rsort;
        }

        public IQueryable<Rsort> GetRsortbyTop(int top)
        {
            var sort = from m in db.Rsort
                       orderby m.RsortId descending
                       select m;
            return sort.Take(top);
        }

        public IEnumerable<Rsort> WhereRsortById(int id)
        {
            var rsort = db.Rsort.Where(c => c.RsortId == id);
            return rsort;
        }
    }
}
