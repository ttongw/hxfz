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
    public class ArreplyManager
    {
        IArreply iarreply = DataAccess.CreateArreply();
        public IEnumerable<Arreply> GetArreply()
        {
            var arr = iarreply.GetArreply();
            return arr;
        }

        public Arreply GetArreplyById(int? id)
        {
            var arr = iarreply.GetArreplyById(id);
            return arr;
        }
    }
}
