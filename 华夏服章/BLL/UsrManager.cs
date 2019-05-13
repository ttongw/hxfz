using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALFactory;
using IDAL;
using Models;
namespace BLL
{
   public class UsrManager
    {
        IUsr iuserinfo = DataAccess.CreateUsr();
        public void AddUserInfo(Usr userInfo)
        {
            iuserinfo.AddUserInfo(userInfo);
        }
        public Usr Denglu(int Users_id, string UserPass)
        {
            var userInfo = iuserinfo.Denglu(Users_id, UserPass);
            return userInfo;
        }



        public void Concern(Concern us)
        {
            iuserinfo.Concern(us);
        }

        public IEnumerable<View_UserInfo> CountConcern1ById(int UsrId)
        {
            var u1 = iuserinfo.CountConcern1ById(UsrId);
            return u1;
        }

        public IEnumerable<View_UserInfo> CountConcern2ById(int UsrId)
        {
            var u2 = iuserinfo.CountConcern2ById(UsrId);
            return u2;
        }


        public Usr GetUsrById(int UsrId)
        {
            var usr = iuserinfo.GetUsrById(UsrId);
            return usr;
        }

        public IEnumerable<Usr> IEGetUsrById(int UsrId)
        {
            var usr = iuserinfo.IEGetUsrById(UsrId);
            return usr;
        }

        public void QuCiaoGuanZhu(int usrA, int usrB)
        {
            iuserinfo.QuCiaoGuanZhu(usrA, usrB);
        }

        public IEnumerable<Usr> Search(string search)
        {
            var usr = iuserinfo.Search(search);
            return usr;
        }

        public void UpdateUsrInfo(Usr usr)
        {
            iuserinfo.UpdateUsrInfo(usr);
        }
    }
}
