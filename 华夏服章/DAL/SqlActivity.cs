using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DAL
{
    public class SqlActivity : IActivity
    {
        HanFuEntities db= DbContextFactory.CreateDbContext();

        public void AttendActivity(AttendActivity attend)
        {
            db.AttendActivity.Add(attend);
            db.SaveChanges();
        }

        public IEnumerable<Activity> GetActivity()
        {
            var act = db.Activity.ToList();
            return act;
        }

        public Activity GetActivityById(int? id)
        {
            Activity act = db.Activity.Find(id);
            return act;
        }

        public IEnumerable<Activity> GetActivityOrderByAttendNumber(int top)
        {
            var act = from m in db.Activity
                      orderby m.attendnumber descending
                      select m;
            return act.Take(top);
        }

        public IEnumerable<Activity> GetActivityOrderByTime(int top)
        {
            var act = from m in db.Activity
                      orderby m.time descending
                      select m;
            return act.Skip(5).Take(top);

        }

        public IEnumerable<Activity> GetActivityOrderByZhuanTi(int top)
        {
           
            var act = from m in db.Activity.Where(p=>p.photodetail=="专题")
                      orderby m.ActiId
                      select m;
            return act.Take(top);
        }

        public IEnumerable<Activity> IEGetActivityById(int top)
        {
            var act = from m in db.Activity
                      orderby m.ActiId
                        select m;
            return act.Take(top);
        }
    }
}
