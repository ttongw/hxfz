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
    public class AncommentManager
    {
        IAncomment iancomment = DataAccess.CreateAncomment();
        public IEnumerable<Ancomment> GetAncomment()
        {
            var anc = iancomment.GetAncomment();
            return anc;
        }

        public Ancomment GetAncommentById(int? id)
        {
            Ancomment ancomment = iancomment.GetAncommentById(id);
            return ancomment;
        }

        public IQueryable<Anreply> GetAnreplyByAncommentId(int id)
        {
            var anreply = iancomment.GetAnreplyByAncommentId(id);
            return anreply;
        }
    }
}
