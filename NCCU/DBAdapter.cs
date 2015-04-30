using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;


namespace NCCU
{
    public class DBAdapter
    {
        public static void LoadSettings()
        {
            if (String.IsNullOrEmpty(GlobalData.DBConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                throw new Exception("Null or empty connection string found in 'DefaultConnection'. Please check web.config for details.");
            }
            //Debugger.LogI("/OvtDBConnectionString='{0}'", GlobalData.OvtDBConnectionString);

            //GlobalData.dc = new DreamMallDataContext(GlobalData.DreamMallDBConnectionString);
        }

    }

}