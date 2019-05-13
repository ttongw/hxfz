using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IRelic
    {
        IEnumerable<Relic> GetRelic();
        Relic GetRelicById(int? id);
        IEnumerable<Relic> IEGetRelicById(int top);
        IEnumerable<Relic> WhereGetRelicById(int id);


    }
}
