using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 华夏服章.Controllers
{
    public class HomeController : Controller
    {
        RelicManager relicManager = new RelicManager();
        ActivityManager activityManager = new ActivityManager();
        UsrManager usrManager = new UsrManager();
        public ActionResult Index()
        { 
            var relic1 = relicManager.IEGetRelicById(3);
            var act1 = activityManager.IEGetActivityById(3);

            ViewModel.IndexViewModel ivm = new ViewModel.IndexViewModel();
            ivm.Relic1 = relic1;
            ivm.Activity1 = act1;

            return View(ivm);
        }

    }
}