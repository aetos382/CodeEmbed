namespace CodeEmbed.Core.GitHub
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public interface IGitHubClient
    {
        Uri RootUri { get; set; }
    }
}
