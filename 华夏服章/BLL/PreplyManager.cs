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
    public class PreplyManager
    {
        IPreply ipreply = DataAccess.CreatePreply();
        public IEnumerable<Preply> GetPreply()
        {
            var preply = ipreply.GetPreply();
            return preply;
        }

        public Preply GetPreplyById(int? id)
        {
            Preply pre = ipreply.GetPreplyById(id);
            return pre;
        }
    }
}
