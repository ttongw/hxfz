using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IArticle
    {
        IEnumerable<Article> GetArticle();
        Article GetArticleById(int? id);
        IQueryable<Article> whereArticleById(int id);

        //IQueryable<Anreply> GetAnreplyByAnswerId(int id);
        int CountArticleById(int arid);
        IEnumerable<Article> Search(string search);
    }
}
