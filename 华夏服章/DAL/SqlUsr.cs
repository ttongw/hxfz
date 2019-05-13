using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDAL;
using Models;

namespace DAL
{
    public class SqlUsr:IUsr
    {
        HanFuEntities db = new HanFuEntities();

        public void AddUserInfo(Usr userInfo)
        {
            db.Usr.Add(userInfo);
            db.SaveChanges();
        }

        public Usr Denglu(int Users_id, string UserPass)
        {
            var userInfo = db.Usr.Where(u => u.UsrId == Users_id)
                 .Where(u => u.Pwd == UserPass).FirstOrDefault();
           
            return userInfo;
        }

        public void Concern(Concern us)
        {
            db.Concern.Add(us);
            db.SaveChanges();
        }

        public IEnumerable<View_UserInfo> CountConcern1ById(int UsrId)
        {
            var userA = from m in db.View_UserInfo
                        where m.UsrA == UsrId
                        select m;
            return userA;
        }

        public IEnumerable<View_UserInfo> CountConcern2ById(int UsrId)
        {
            var userB = from n in db.View_UserInfo
                        where n.UsrB == UsrId
                        select n;
            return userB;
        }
        public Usr GetUsrById(int UsrId)
        {
            Usr usr = db.Usr.Find(UsrId);
            return usr;
        }

        public IEnumerable<Usr> IEGetUsrById(int UsrId)
        {
            var user = db.Usr.Where(c => c.UsrId == UsrId);
            return user;
        }

        public void QuCiaoGuanZhu(int usrA, int usrB)
        {
            var usr = from p in db.Concern
                      where p.UsrA == usrA && p.UsrB == usrB
                      select p;
            db.Concern.Remove(usr.FirstOrDefault());
            db.SaveChanges();
        }

        public IEnumerable<Usr> Search(string search)
        {
            var usr = from po in db.Usr
                      where po.UsrName.Contains(search) || po.UsrId.Equals(search)
                      select po;
            return usr.ToList();
        }

        public void UpdateUsrInfo(Usr usr)
        {
            db.Entry(usr).State = EntityState.Modified;
            db.SaveChanges();
        }




    }
}
