namespace CodeEmbed.Web.Site
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Web.Mvc;

    public static class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            Contract.Requires<ArgumentNullException>(filters != null);

            filters.Add(new HandleErrorAttribute());
        }
    }
}
