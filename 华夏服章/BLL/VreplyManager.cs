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
    public class VreplyManager
    {
        IVreply ivreply = DataAccess.CreateVreply();
        public IEnumerable<Vreply> GetVreply()
        {
            var vre = ivreply.GetVreply();
            return vre;
        }

        public Vreply GetVreplyById(int? id)
        {
            var vre = ivreply.GetVreplyById(id);
            return vre;
        }
    }
}
