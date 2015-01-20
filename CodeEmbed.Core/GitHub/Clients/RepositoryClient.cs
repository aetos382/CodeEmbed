namespace CodeEmbed.Core.GitHub.Models.Internals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CodeEmbed.Core.GitHub.Clients;

    internal class RepositoryClient :
        Repository,
        IRepositoryClient
    {
        private readonly IGitHubClient _client;

        public RepositoryClient(IGitHubClient client)
        {
            this._client = client;
        }

        #region Implementation of IRepositoryClient

        public Repository Get(
            string user,
            string repository)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
