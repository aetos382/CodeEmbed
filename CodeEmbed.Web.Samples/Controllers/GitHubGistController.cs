﻿namespace CodeEmbed.Web.Samples.Controllers
{
    using System;
    using System.Web.Mvc;

    public class GitHubGistController : Controller
    {
        public ActionResult Default()
        {
            return this.View();
        }
    }
}
