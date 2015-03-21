﻿namespace CodeEmbed.Web.Site
{
    using System;
    using System.Configuration;
    using System.Linq;
    
    public static class Configuration
    {
        public static Uri ApiEndpoint
        {
            get
            {
                string value = ConfigurationManager.AppSettings["apiEndpoint"];
                if (value == null)
                {
                    // TODO: Use derived exception.
                    throw new InvalidOperationException();    
                }

                var uri = new Uri(value);

                return uri;
            }
        }
    }
}
