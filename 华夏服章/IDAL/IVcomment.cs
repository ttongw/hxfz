using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IVcomment
    {
        IEnumerable<Vcomment> GetVcomment();
        Vcomment GetVcommentById(int? id);
        IQueryable<Vreply> GetVreplyByVcommentId(int id);
    }
}
