using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 华夏服章.ViewModel
{
    public class IndexViewModel
    {
        public IEnumerable<Relic> Relic1 { get; set; }
        public IEnumerable<Relic> Relic2 { get; set; }
        public IEnumerable<Relic> Relic3 { get; set; }
        public IEnumerable<Relic> Relic4 { get; set; }

        public IEnumerable<Activity> Activity1 { get; set; }

        public IEnumerable<Rsort> Rsort { get; set; }
        public IEnumerable<RCategory> RCategory { get; set; }
    }
}