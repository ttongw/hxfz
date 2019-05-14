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
    public class PhotographManager
    {
        IPhotograph iphoto = DataAccess.CreatePhotograph();
        public int CountPhotographById(int phid)
        {
            var at = iphoto.CountPhotographById(phid);
            return at;
        }

        public IEnumerable<Photograph> GetPhotograph()
        {
            var pho = iphoto.GetPhotograph();
            return pho;
        }

        public Photograph GetPhotographById(int? id)
        {
            Photograph pho = iphoto.GetPhotographById(id);
            return pho;
        }

        public IEnumerable<Photograph> Search(string search)
        {
            var pho = iphoto.Search(search);
            return pho;
        }
        public IQueryable<Photograph> wherePhotographById(int id)
        {
            var pho = iphoto.wherePhotographById(id);
            return pho;
        }
    }
}
