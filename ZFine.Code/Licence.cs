/*******************************************************************************
 * Copyright © 2016
 * 
 * Description: MVC快速开发平台
 *
*********************************************************************************/
using System.Configuration;
using System.Web;

namespace ZFine.Code
{
    public sealed class Licence
    {
        private static Microsoft.Extensions.Configuration.IConfiguration Configuration { get; }
        public static bool IsLicence(string key)
        {
            string host = HttpContext.Current.Request.PathBase;
            if (host.Equals("localhost"))
                return true;
            string licence = Configuration["AppSettings:LicenceKey"];
            if (licence != null && licence == Md5.md5(key, 32))
                return true;

            return false;
        }
        public static string GetLicence()
        {
            var licence = "78512455-F0B6-4ED1-965B-F0AABC442E2F";//Configs.GetValue("LicenceKey");
            if (string.IsNullOrEmpty(licence))
            {
                licence = Common.GuId();
                Configs.SetValue("LicenceKey", licence);
            }
            return Md5.md5(licence, 32);
        }
    }
}
