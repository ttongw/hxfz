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
    }
}
