using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class SqlRelic : IRelic
    {
        HanFuEntities db = DbContextFactory.CreateDbContext();
        public IEnumerable<Relic> GetRelic()
        {
            var relic = db.Relic.ToList();
            return relic;
        }

        public Relic GetRelicById(int? id)
        {
            Relic relic = db.Relic.Find(id);
            return relic;
        }

        public IEnumerable<Relic> IEGetRelicById(int top)
        {
            var relic = from m in db.Relic
                        orderby m.HFId
                        select m;
            return relic.Take(top);
            //var relic = db.Relic.Where(c => c.HFId == id);
            //return relic;
        }
        public IEnumerable<Relic> WhereGetRelicById(int id)
        {
            var relic = db.Relic.Where(c => c.HFId == id);
            return relic;
        }
    }
}
