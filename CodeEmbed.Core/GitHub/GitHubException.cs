﻿namespace CodeEmbed.Core.GitHub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GitHubException :
        Exception
    {
        public GitHubException()
            : base()
        {
        }

        public GitHubException(string message)
            : base(message)
        {
        }

        public GitHubException(
            string message,
            Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
