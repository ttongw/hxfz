using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlArticle:IArticle
    {
        HanFuEntities db = DbContextFactory.CreateDbContext();
        public int CountArticleById(int arid)
        {
            var at = db.Article.Where(c => c.ArticleId == arid).Select(c => c.ArticleId).Count();
            return at;
        }

        //public IQueryable<Anreply> GetAnreplyByAnswerId(int id)
        //{
        //    var answer = db.Anreply.Include("Ancomment").Where(o => o.AnswerId == id);
        //    return answer;
        //}

        public IEnumerable<Article> GetArticle()
        {
            var article = db.Article.ToList();
            return article;
        }

        public Article GetArticleById(int? id)
        {
            Article art = db.Article.Where(c => c.ArticleId == id).FirstOrDefault();
            return art;
        }

        public IEnumerable<Article> Search(string search)
        {
            var article = db.Article.Where(c => c.Title.Contains(search));
            return article;
        }

        public IQueryable<Article> whereArticleById(int id)
        {
            var art = db.Article.Where(c => c.ArticleId == id);
            return art;
        }
    }
}
