
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace IDAL
{
  public  interface IUsr
    {
        void AddUserInfo(Usr userInfo);
        Usr Denglu(int Users_id, string UserPass);

        Usr GetUsrById(int UsrId);
        void UpdateUsrInfo(Usr usr);
        IEnumerable<Usr> IEGetUsrById(int UsrId);
        IEnumerable<Usr> Search(string search);

        IEnumerable<View_UserInfo> CountConcern1ById(int UsrId);
        IEnumerable<View_UserInfo> CountConcern2ById(int UsrId);

        void Concern(Concern us);
        void QuCiaoGuanZhu(int usrA, int usrB);


    }
}
