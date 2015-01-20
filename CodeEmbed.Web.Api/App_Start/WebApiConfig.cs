namespace CodeEmbed.Web.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Web.Http;
    using System.Web.Http.Routing;

    using CodeEmbed.Web.Http.Formatting;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API ルート
            config.MapHttpAttributeRoutes();

            config.Formatters.Add(new PlainTextMediaTypeFormatter());
        }
    }
}
