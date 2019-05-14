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
     public class ArticleManager
    {
        IArticle iarticle = DataAccess.CreateArticle();
        public int CountArticleById(int arid)
        {
            var at = iarticle.CountArticleById(arid);
            return at;
        }

        //public IQueryable<Anreply> GetAnreplyByAnswerId(int id)
        //{
        //    var answer = db.Anreply.Include("Ancomment").Where(o => o.AnswerId == id);
        //    return answer;
        //}

        public IEnumerable<Article> GetArticle()
        {
            var article = iarticle.GetArticle();
            return article;
        }

        public Article GetArticleById(int? id)
        {
            Article art = iarticle.GetArticleById(id);
            return art;
        }

        public IEnumerable<Article> Search(string search)
        {
            var article = iarticle.Search(search);
            return article;
        }
        public IQueryable<Article> whereArticleById(int id)
        {
            var art = iarticle.whereArticleById(id);
            return art;
        }
    }
}
