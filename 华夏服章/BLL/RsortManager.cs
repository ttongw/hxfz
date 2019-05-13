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
    public class RsortManager
    {
        IRsort irsort = DataAccess.CreateRsort();
        public IEnumerable<Rsort>GetRsort()
        {
            var rsort = irsort.GetRsort();
            return rsort;
        }
        public Rsort GetRsortById(int ?id)
        {
            Rsort rsort = irsort.GetRsortById(id);
            return rsort;
        }
        public IEnumerable<Rsort> WhereRsortById(int id)
        {
            var rsort = irsort.WhereRsortById(id);
            return rsort;
        }
        public IEnumerable<Relic> GetRelicByRsortId(int id)
        {
            var relic = irsort.GetRelicByRsortId(id);
            return relic;
        }
        public IQueryable<Rsort> GetRsortbyTop(int top)
        {
            var rsort = irsort.GetRsortbyTop(top);
            return rsort;
        }

    }
}
