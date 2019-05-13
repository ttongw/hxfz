using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 华夏服章.ViewModel
{
    public class UserCenterViewModel
    {
        public IEnumerable<Usr> Usr1 { get; set; }
        public Usr Usr { get; set; }//修改资料
        public IEnumerable<Concern> Concern1 { get; set; }
        public int UsrA { get; set; }//关注数
        public IEnumerable<View_UserInfo> UsrAa { get; set; }
        public int UsrB { get; set; }
        public IEnumerable<View_UserInfo> UsrBb { get; set; }
        public IEnumerable<SelectListItem> List1 { get; set; }

    }
}