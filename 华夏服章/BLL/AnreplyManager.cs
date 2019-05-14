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
    public class AnreplyManager
    {
        IAnreply ianreply = DataAccess.CreateAnreply();
        public IEnumerable<Anreply> GetAnreply()
        {
            var anr = ianreply.GetAnreply();
            return anr;
        }

        public Anreply GetAnreplyById(int? id)
        {
            var anr = ianreply.GetAnreplyById(id);
            return anr;
        }
    }
}
