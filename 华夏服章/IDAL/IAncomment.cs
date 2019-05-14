using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IAncomment
    {
        IEnumerable<Ancomment> GetAncomment();
        Ancomment GetAncommentById(int? id);
        IQueryable<Anreply> GetAnreplyByAncommentId(int id);
    }
}
