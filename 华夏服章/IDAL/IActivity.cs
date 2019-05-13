using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IActivity
    {
        IEnumerable<Activity> GetActivity();
        Activity GetActivityById(int? id);
        IEnumerable<Activity> IEGetActivityById(int top);
        IEnumerable<Activity> GetActivityOrderByTime(int top);

        IEnumerable<Activity> GetActivityOrderByZhuanTi(int top);
        IEnumerable<Activity> GetActivityOrderByAttendNumber(int top);

        void AttendActivity(AttendActivity attend);
    }
}
