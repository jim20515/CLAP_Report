using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;

namespace NCCU
{
    public class GlobalData
    {
        #region NCCU
        public static string DBConnectionString;

        public static int PageSize = 10;
        //public static DreamMallDataContext dc;
        //
        public static string Salt = "designlab";
        //
        public static string Vision = "Ver1.1.1";
        //image
        public static string[] ImageFormats = new string[] { ".jpg", ".png", ".gif", ".jpeg" };
        

        #endregion
    }

    public static class EventLog
    {
        public static string FilePath { get; set; }

        public static void Write(string format, params object[] arg)
        {
            Write(string.Format(format, arg));
        }

        public static void Write(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);

            if (string.IsNullOrEmpty(FilePath))
            {
                //FilePath = Directory.GetCurrentDirectory();
                FilePath = HttpContext.Current.Server.MapPath("~/");
            }
            string filename = FilePath +
                string.Format("\\ErrorLog.txt");
            FileInfo finfo = new FileInfo(filename);
            if (finfo.Directory.Exists == false)
            {
                finfo.Directory.Create();
            }
            string writeString = string.Format("{0:yyyy/MM/dd HH:mm:ss} {1}",
                DateTime.Now, message) + Environment.NewLine;
            File.AppendAllText(filename, writeString, Encoding.Unicode);
        }
    }

}