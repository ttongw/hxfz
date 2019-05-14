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
    public class AnswerManager
    {
        IAnswer ianswer = DataAccess.CreateAnswer();
        public int CountAnswerById(int anid)
        {
            var at = ianswer.CountAnswerById(anid);
            return at;
        }

        //public IQueryable<Anreply> GetAnreplyByAnswerId(int id)
        //{
        //    var answer = db.Anreply.Include("Ancomment").Where(o => o.AnswerId == id);
        //    return answer;
        //}

        public IEnumerable<Answer> GetAnswer()
        {
            var answer = ianswer.GetAnswer();
            return answer;
        }

        public Answer GetAnswerById(int? id)
        {
            Answer ans = ianswer.GetAnswerById(id);
            return ans;
        }

        public IEnumerable<Answer> Search(string search)
        {
            var answer = ianswer.Search(search);
            return answer;
        }
        public IQueryable<Answer> whereAnswerById(int id)
        {
            var ans = ianswer.whereAnswerById(id);
            return ans;
        }
    }
}
