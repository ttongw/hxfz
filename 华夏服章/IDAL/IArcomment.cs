using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IArcomment
    {
        IEnumerable<Arcomment> GetArcomment();
        Arcomment GetArcommentById(int? id);
        IQueryable<Arreply> GetArreplyByArcommentId(int id);
    }
}
