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
    public class VcommentManager
    {
        IVcomment ivcomment=DataAccess.CreateVcomment();
        public IEnumerable<Vcomment> GetVcomment()
        {
            var vc = ivcomment.GetVcomment();
            return vc;
        }

        public Vcomment GetVcommentById(int? id)
        {
            Vcomment vcomment = ivcomment.GetVcommentById(id);
            return vcomment;
        }

        public IQueryable<Vreply> GetVreplyByVcommentId(int id)
        {
            var vreply = ivcomment.GetVreplyByVcommentId(id);
            return vreply;
        }
    }
}
