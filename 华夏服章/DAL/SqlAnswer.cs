using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class SqlAnswer : IAnswer
    {
        HanFuEntities db = DbContextFactory.CreateDbContext();
        public int CountAnswerById(int anid)
        {
            var at = db.Answer.Where(c => c.AnswerId == anid).Select(c => c.AnswerId).Count();
            return at;
        }

        //public IQueryable<Anreply> GetAnreplyByAnswerId(int id)
        //{
        //    var answer = db.Anreply.Include("Ancomment").Where(o => o.AnswerId == id);
        //    return answer;
        //}

        public IEnumerable<Answer> GetAnswer()
        {
            var answer = db.Answer.ToList();
            return answer;
        }

        public Answer GetAnswerById(int? id)
        {
            Answer ans = db.Answer.Where(c => c.AnswerId == id).FirstOrDefault();
            return ans;
        }

        public IEnumerable<Answer> Search(string search)
        {
            var answer = db.Answer.Where(c => c.Title.Contains(search));
            return answer;
        }

        public IQueryable<Answer> whereAnswerById(int id)
        {
            var ans = db.Answer.Where(c => c.AnswerId == id);
            return ans;
        }
    }
}
