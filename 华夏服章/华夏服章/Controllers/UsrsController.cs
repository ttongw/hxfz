using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;
using 华夏服章.Attributes;
using 华夏服章.ViewModel;
namespace 华夏服章.Controllers
{
    public class UsrsController : Controller
    {
      HanFuEntities db = new HanFuEntities();
      UsrManager userinfomanager = new UsrManager();
   
      
        public ActionResult Index()
        {
            return View();
        }

   
        public ActionResult Login()
        {
            return View();
        }

        
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include = "UsrId,Pwd")] int UsrId,string Pwd)
        {
            if (ModelState.IsValid)
            {

                userinfomanager.Denglu(UsrId,Pwd);
                Session["UsrId"] = UsrId;
                return Content("<script>;alert('登录成功!');history.go(-2) </script>");
            }
            else
            {
                return Content("<script>;alert('登录失败！');history.go(-2)");
            }
        }
    
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register([Bind(Include = "UsrName,Pwd")] Usr userInfo)
        {
            if (ModelState.IsValid)
            {
               
                userinfomanager.AddUserInfo(userInfo);
                return Content("<script>;alert('注册成功!');history.go(-3) </script>");
            }
            else
            {
                return Content("<script>;alert('注册失败！');");
            }
        }
        [Login]
        public ActionResult UserCenter(int UsrId)
        {
            UserCenterViewModel uc = new UserCenterViewModel();
            uc.Usr1 = userinfomanager.IEGetUsrById(UsrId);
            ViewBag.UsrId = UsrId;

            uc.Usr = db.Usr.Find(UsrId);
            Session["Concern"] = 0;

            uc.UsrA = userinfomanager.CountConcern1ById(UsrId).Count();
            uc.UsrB = userinfomanager.CountConcern2ById(UsrId).Count();
            uc.UsrAa = userinfomanager.CountConcern1ById(UsrId);
            uc.UsrBb = userinfomanager.CountConcern2ById(UsrId);

            foreach (var item in userinfomanager.CountConcern2ById(UsrId))
            {
                if (Session["UsrId"] != null)
                {
                    if (item.UsrA == Convert.ToInt32(Session["Users_id"].ToString()))
                    {
                        Session["Concern"] = 1;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return View();
        }
        public string Concern(int UsrB)
        {
            Concern us = new Concern();
            us.UsrA = Convert.ToInt32(Session["UsrId"].ToString());
            us.UsrB = UsrB;
            userinfomanager.Concern(us);
            string aa = userinfomanager.CountConcern2ById(UsrB).Count().ToString();
            return aa;
        }
        public string QuXiaoGuanZhu(int UsrB)
        {
            Concern us = new Concern();
            int UsrA = Convert.ToInt32(Session["UsrId"].ToString());
            userinfomanager.QuCiaoGuanZhu(UsrA, UsrB);

            string aa = userinfomanager.CountConcern2ById(UsrB).Count().ToString();
            return aa;
        }


    }
}
