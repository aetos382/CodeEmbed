﻿namespace CodeEmbed.Web.Site
{
    using System;
    using System.Web.Optimization;

    public class BundleConfig
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
                    "~/Scripts/SyntaxHighlighter/shBrushCSharp.js"));

            // 開発と学習には、Modernizr の開発バージョンを使用します。次に、実稼働の準備が
            // できたら、http://modernizr.com にあるビルド ツールを使用して、必要なテストのみを選択します。
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

            bundles.Add(new StyleBundle("~/Content/SyntaxHighlighter").Include(
                "~/Content/SyntaxHighlighter/shCore.css",
                "~/Content/SyntaxHighlighter/shThemeEclipse.css"));
        }
    }
}