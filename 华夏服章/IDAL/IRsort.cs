using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IRsort
    {
        IEnumerable<Rsort> GetRsort();
        Rsort GetRsortById(int? id);
        IEnumerable<Rsort> WhereRsortById(int id);
        IEnumerable<Relic> GetRelicByRsortId(int id);
        IQueryable<Rsort> GetRsortbyTop(int top);

    }
}
