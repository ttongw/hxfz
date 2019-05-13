using DALFactory;
using IDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ActivityManager
    {
        IActivity iact = DataAccess.CreateActivity();
        public IEnumerable<Activity>GetActivity()
        {
            var act = iact.GetActivity();
            return act;
        }
        public Activity GetActivityById(int ?id)
        {
            Activity act = iact.GetActivityById(id);
            return act;
        }
        public IEnumerable<Activity> IEGetActivityById(int id)
        {
            var act = iact.IEGetActivityById(id);
            return act;
        }
        public IEnumerable<Activity> GetActivityOrderByTime(int id)
        {
            var act = iact.GetActivityOrderByTime(id);
            return act;
        }
        public IEnumerable<Activity> GetActivityOrderByZhuanTi(int id)
        {
            var act = iact.GetActivityOrderByZhuanTi(id);
            return act;
        }
        public IEnumerable<Activity> GetActivityOrderByAttendNumber(int id)
        {
            var act = iact.GetActivityOrderByAttendNumber(id);
            return act;
        }
        public void AttendActivity(AttendActivity attend)
        {
            iact.AttendActivity(attend);
           
        }
            }
}
