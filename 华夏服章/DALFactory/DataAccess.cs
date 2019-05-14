using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;
using Models;
using IDAL;
namespace DALFactory
{
    public class DataAccess
    {
        private static string AssemblyName = ConfigurationManager.AppSettings["Path"].ToString();
        private static string db = ConfigurationManager.AppSettings["DB"].ToString();
        public static IUsr CreateUsr()
        {
            string className = AssemblyName + "." + db + "Usr";
            return (IUsr)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IRelic CreateRelic()
        {
            string className = AssemblyName + "." + db + "Relic";
            return (IRelic)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IActivity CreateActivity()
        {
            string className = AssemblyName + "." + db + "Activity";
            return (IActivity)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IRsort CreateRsort()
        {
            string className = AssemblyName + "." + db + "Rsort";
            return (IRsort)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IVideo CreateVideo()
        {
            string className = AssemblyName + "." + db + "Video";
            return (IVideo)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IAnswer CreateAnswer()
        {
            string className = AssemblyName + "." + db + "Answer";
            return (IAnswer)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IArticle CreateArticle()
        {
            string className = AssemblyName + "." + db + "Article";
            return (IArticle)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IPhotograph CreatePhotograph()
        {
            string className = AssemblyName + "." + db + "Photograpgh";
            return (IPhotograph)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IAncomment CreateAncomment()
        {
            string className = AssemblyName + "." + db + "Ancomment";
            return (IAncomment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IArcomment CreateArcomment()
        {
            string className = AssemblyName + "." + db + "Arcomment";
            return (IArcomment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IVcomment CreateVcomment()
        {
            string className = AssemblyName + "." + db + "Vcomment";
            return (IVcomment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IPcomment CreatePcomment()
        {
            string className = AssemblyName + "." + db + "Pcomment";
            return (IPcomment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IAnreply CreateAnreply()
        {
            string className = AssemblyName + "." + db + "Anreply";
            return (IAnreply)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IArreply CreateArreply()
        {
            string className = AssemblyName + "." + db + "Arreply";
            return (IArreply)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IVreply CreateVreply()
        {
            string className = AssemblyName + "." + db + "Vreply";
            return (IVreply)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IPreply CreatePreply()
        {
            string className = AssemblyName + "." + db + "Preply";
            return (IPreply)Assembly.Load(AssemblyName).CreateInstance(className);
        }

    }
}
