using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class SqlPhotograph : IPhotograph
    {
        HanFuEntities db = DbContextFactory.CreateDbContext();
        public int CountPhotographById(int phid)
        {
            var at = db.Photograph.Where(c => c.PhId == phid).Select(c => c.PhId).Count();
            return at;
        }

        public IEnumerable<Photograph> GetPhotograph()
        {
            var pho = db.Photograph.ToList();
            return pho;
        }

        public Photograph GetPhotographById(int? id)
        {
            Photograph pho = db.Photograph.Where(c => c.PhId == id).FirstOrDefault();
            return pho;
        }

        public IEnumerable<Photograph> Search(string search)
        {
            var pho = db.Photograph.Where(c => c.Title.Contains(search));
            return pho;
        }

        public IQueryable<Photograph> wherePhotographById(int id)
        {
            var pho = db.Photograph.Where(c => c.PhId == id);
            return pho;
        }
    }
}
