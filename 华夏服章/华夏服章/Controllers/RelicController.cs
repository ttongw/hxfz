using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using System.Net;

namespace 华夏服章.Controllers
{
    public class RelicController : Controller
    {
        // GET: Relic
        HanFuEntities db = new HanFuEntities();
        RelicManager relic = new RelicManager();

        public ActionResult RelicIndex()
        {
            var relic1 = relic.WhereGetRelicById(4);
            var relic2 = relic.WhereGetRelicById(11);
            var relic3 = relic.WhereGetRelicById(12);
            var relic4 = relic.WhereGetRelicById(13);

            ViewModel.IndexViewModel ivm = new ViewModel.IndexViewModel();
            ivm.Relic1 = relic1;
            ivm.Relic2 = relic2;
            ivm.Relic3 = relic3;
            ivm.Relic4 = relic4;

            return View(ivm);
        }
        public ActionResult Index()
        {
            var sort = db.Rsort.ToList();
            return View(sort);
        }
        public ActionResult Index2(String genreInfoFrom, string currentFilter, int? page)
        {
            var rel = relic.GetRelic();

            if (genreInfoFrom != null)
            {
                page = 1;
            }
            else
            {
                genreInfoFrom = currentFilter;
            }

            ViewBag.CurrentFilter = genreInfoFrom;

            if (!String.IsNullOrEmpty(genreInfoFrom))
            {
                rel = rel.Where(x => x.Rsort.dynasty == genreInfoFrom);

            }
            int pageSize = 12;
            int pageNumber = (page ?? 1);

            return PartialView(rel.ToPagedList(pageNumber, pageSize));
        }
        public ActionResult Details(int RelicId)
        {
            Session["RelicId"] = RelicId;
            if (Session["RelicId"] == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var relics = relic.GetRelicById(RelicId);
            if (relics == null)
            {
                return HttpNotFound();
            }
            return View(relics);
        }
    }
}