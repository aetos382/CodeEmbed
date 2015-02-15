namespace CodeEmbed.GitHubClient.JsonNet.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal interface IModel
    {
        string Name { [Pure] get; }
    }
}
