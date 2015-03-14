namespace CodeEmbed.Web.Site
{
    using System;
    using System.Web.Optimization;

    public static class BundleConfig
    {
        // バンドルの詳細については、http://go.microsoft.com/fwlink/?LinkId=301862  を参照してください
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(
                new ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"));

            bundles.Add(
                new ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"));

            bundles.Add(
                new ScriptBundle("~/bundles/SyntaxHighlighter").Include(
                    "~/Scripts/SyntaxHighlighter/shCore.js",
                    "~/Scripts/SyntaxHighlighter/shBrushCSharp.js",
                    "~/Scripts/SyntaxHighlighter/shBrushJScript.js"));

            bundles.Add(
                new ScriptBundle("~/bundles/LightView").Include(
                    "~/Scripts/lightview/lightview.js",
                    "~/Scripts/spinners/spinners.js"));

            bundles.Add(
                new ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"));

            bundles.Add(
                new ScriptBundle("~/bundles/bootstrap").Include(
                    "~/Scripts/bootstrap.js",
                    "~/Scripts/respond.js"));

            bundles.Add(
                new StyleBundle("~/Content/css").Include(
                    "~/Content/bootstrap.css",
                    "~/Content/site.css"));
        }
    }
}
