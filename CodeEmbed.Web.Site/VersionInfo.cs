namespace CodeEmbed.Web.Site
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Web;

    public static class VersionInfo
    {
        public static string BuildNo
        {
            get
            {
                return ConfigurationManager.AppSettings["ver:BuildNo"];
            }
        }

        public static string Branch
        {
            get
            {
                return ConfigurationManager.AppSettings["ver:Branch"];
            }
        }

        public static string Commit
        {
            get
            {
                return ConfigurationManager.AppSettings["ver:Commit"];
            }
        }

        public static string Configuration
        {
            get
            {
                return ConfigurationManager.AppSettings["ver:Configuration"];
            }
        }
    }
}
