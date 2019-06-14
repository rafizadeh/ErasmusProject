using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace ErasmusApp.Areas.Admin.Helpers
{
    public class FileManager
    {
        public static string Upload(HttpPostedFileBase File,string _path)
        {
            string filename = DateTime.Now.ToString("yyyyMMddHHmmssfff") + File.FileName;
            string path = Path.Combine(HttpContext.Current.Server.MapPath($"~/Uploads/{_path}/"), filename);
            File.SaveAs(path);

            return filename;
        }

        public static void Delete(string filename,string _path)
        {
            string path = Path.Combine(HttpContext.Current.Server.MapPath($"~/Uploads/{_path}/"), filename);

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}