﻿namespace CodeEmbed.Web.Site.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Default()
        {
            return this.View();
        }

        public ActionResult GitHubGit()
        {
            return this.View();
        }

        public ActionResult GitHubGist()
        {
            return this.View();
        }
    }
}
