using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using 华夏服章.ViewModel;

namespace 华夏服章.Controllers
{
    public class MomentsController : Controller
    {
        // GET: Moments
        HanFuEntities db = new HanFuEntities();
        AnswerManager answermanager = new AnswerManager();
        ArticleManager articlemanager = new ArticleManager();
        VideoManager videomanager = new VideoManager();
        PhotographManager photomanager = new PhotographManager();

        AncommentManager ancommentmanager = new AncommentManager();
        ArcommentManager arcommentmanager = new ArcommentManager();
        VcommentManager vcommentmanager = new VcommentManager();
        PcommentManager pcommentmanager = new PcommentManager();

        AnreplyManager anreplymanager = new AnreplyManager();
        ArreplyManager arreplymanager = new ArreplyManager();
        VreplyManager vreplymanager = new VreplyManager();
        PreplyManager preplymanager = new PreplyManager();
        public ActionResult Index()
        {
            var answer1 = answermanager.whereAnswerById(1);
            var answer2 = answermanager.whereAnswerById(2);
            var answer3 = answermanager.whereAnswerById(3);

            var article1 = articlemanager.whereArticleById(1);
            var article2 = articlemanager.whereArticleById(2);
            var article3 = articlemanager.whereArticleById(3);

            var photo1 = photomanager.wherePhotographById(1);
            var photo2 = photomanager.wherePhotographById(2);
            var photo3 = photomanager.wherePhotographById(3);

            var hotvideo = videomanager.GetHotVideo().Take(3);

            ViewModel.MomentsViewModel momentvm = new ViewModel.MomentsViewModel();
            momentvm.Answer1 = answer1;
            momentvm.Answer2 = answer2;
            momentvm.Answer3 = answer3;
            momentvm.Article1 = article1;
            momentvm.Article2 = article2;
            momentvm.Article3 = article3;
            momentvm.Photograph1 = photo1;
            momentvm.Photograph2 = photo2;
            momentvm.Photograph3 = photo3;
            momentvm.GetHotVideo = hotvideo;
            return View(momentvm);
        }


        public ActionResult AnswerIndex()
        {
            return View();
        }
        public ActionResult AnDetails()
        {
            return View();
        }


        public ActionResult ArticleIndex()
        {
            return View();
        }
        public ActionResult ArDetails()
        {
            return View();
        }


        public ActionResult VideoIndex()
        {
            return View();
        }
        public ActionResult ViDetails()
        {
            return View();
        }


        public ActionResult PhotoIndex()
        {
            return View();
        }
        public ActionResult PhDetails()
        {
            return View();
        }
    }
}