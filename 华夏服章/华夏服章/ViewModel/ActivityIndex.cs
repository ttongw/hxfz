using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 华夏服章.ViewModel
{
    public class ActivityIndex
    {
        public IEnumerable<Activity> Activity1 { get; set; }
        public IEnumerable<Activity> Activity2 { get; set; }

        public IEnumerable<Activity> Activity3 { get; set; }
    }
}