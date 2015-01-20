namespace CodeEmbed.Core.GitHub.Clients
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CodeEmbed.Core.GitHub.Models;

    public interface IRepositoryClient
    {
        Repository Get(
            string user,
            string repository);
    }
}
