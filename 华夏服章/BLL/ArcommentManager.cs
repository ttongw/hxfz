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
    public class ArcommentManager
    {
        IArcomment iarcomment = DataAccess.CreateArcomment();
        public IEnumerable<Arcomment> GetArcomment()
        {
            var arc = iarcomment.GetArcomment();
            return arc;
        }

        public Arcomment GetArcommentById(int? id)
        {
            Arcomment arcomment = iarcomment.GetArcommentById(id);
            return arcomment;
        }

        public IQueryable<Arreply> GetArreplyByArcommentId(int id)
        {
            var arreply = iarcomment.GetArreplyByArcommentId(id);
            return arreply;
        }
    }
}
