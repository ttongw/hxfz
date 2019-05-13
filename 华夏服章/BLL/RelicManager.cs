using DALFactory;
using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RelicManager
    {
        IRelic irelic = DataAccess.CreateRelic();
        public IEnumerable<Relic> GetRelic()
        {
            var relic = irelic.GetRelic();
            return relic;
        }
        public Relic GetRelicById(int? id)
        {
            Relic relic = irelic.GetRelicById(id);
            return relic;
        }
        public IEnumerable<Relic> IEGetRelicById(int top)
        {
            var relic = irelic.IEGetRelicById(top);
            return relic;
        }
        public IEnumerable<Relic> WhereGetRelicById(int id)
        {
            var relic = irelic.WhereGetRelicById(id);
            return relic;
        }
    }
}
