namespace CodeEmbed.Web.Site
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    
    public static class Configuration
    {
        public static Uri ApiEndpoint
        {
            get
            {
                string value = ConfigurationManager.AppSettings["apiEndpoint"];
                var uri = new Uri(value);

                return uri;
            }
        }
    }
}
