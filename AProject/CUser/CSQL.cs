using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AProject.CUser
{
    public class CSQL
    {
        public static string LocalConnectionString { get; set; }
        public static string RemoteConnectionString { get; set; }

        // 在初始化方法或建構函式中賦值
        static CSQL()
        {
            LocalConnectionString = "Data Source=.;Initial Catalog=Aproject;Integrated Security=True;Encrypt=False";
            RemoteConnectionString = "Data Source=192.168.35.57,1433;Initial Catalog=Aproject;User ID=Jarek0122;Encrypt=False";
        }
    }
}
