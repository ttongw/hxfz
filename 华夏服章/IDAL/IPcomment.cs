using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IPcomment
    {
        IEnumerable<Pcomment> GetAncomment();
        Pcomment GetAncommentById(int? id);
        IQueryable<Preply> GetPreplyByPcommentId(int id);
    }
}
