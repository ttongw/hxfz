using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IAnswer
    {
        IEnumerable<Answer> GetAnswer();
        Answer GetAnswerById(int? id);
        IQueryable<Answer> whereAnswerById(int id);
        //IQueryable<Anreply> GetAnreplyByAnswerId(int id);
        int CountAnswerById(int anid);
        IEnumerable<Answer> Search(string search);
    }
}
