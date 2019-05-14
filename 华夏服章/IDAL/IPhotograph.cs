using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IPhotograph
    {
        IEnumerable<Photograph> GetPhotograph();
        Photograph GetPhotographById(int? id);
        IQueryable<Photograph> wherePhotographById(int id);
        int CountPhotographById(int phid);
        IEnumerable<Photograph> Search(string search);
    }
}
