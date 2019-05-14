using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IAnreply
    {
        IEnumerable<Anreply> GetAnreply();
        Anreply GetAnreplyById(int? id);
    }
}
