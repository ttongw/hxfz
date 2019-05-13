using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;
using 华夏服章.Attributes;


namespace 华夏服章.Controllers
{
    public class ActivityController : Controller
    {
        ActivityManager activityManager = new ActivityManager();
        public ActionResult Index()
        {
            var act1 = activityManager.GetActivityOrderByTime(6);
            var act2 = activityManager.GetActivityOrderByZhuanTi(3);
            var act3 = activityManager.GetActivityOrderByAttendNumber(3);
            ViewModel.ActivityIndex ivm = new ViewModel.ActivityIndex();
            ivm.Activity1 = act1;
            ivm.Activity2 = act2;
            ivm.Activity3 = act3;
            return View(ivm);
        }
        public ActionResult Details(int actiId)
        {
            var detail = activityManager.GetActivityById(actiId);
            Session["ActiId"]=actiId;
            return View(detail);
        }


        [HttpPost]
        [ValidateInput(false)]
        [Login]
        public ActionResult SiginUp(AttendActivity attend, int actiId,Activity activity)
        {
            Activity acti=activityManager.GetActivityById(actiId);

            if (ModelState.IsValid)
            {    attend.time= DateTime.Now;
                attend.ActiId = Convert.ToInt32(Request["actiId"]);
                attend.UsrId = Convert.ToInt32(Session["UsrId"].ToString());
                acti.attendnumber++;
                activityManager.AttendActivity(attend);
               
            }
            return Content("<script>;alert('报名成功!');history.go(-1)</script>");
        }
    }
}