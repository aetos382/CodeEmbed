namespace CodeEmbed.Web.Api
{
    using System;
    using System.Linq;
    using System.Web.Http;
    using System.Web.Http.Cors;

    using CodeEmbed.Web.Http.Formatting;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API ルート
            config.MapHttpAttributeRoutes();

            var corsAttribute = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(corsAttribute);

            config.Formatters.Add(new PlaintextMediaTypeFormatter());
        }
    }
}
