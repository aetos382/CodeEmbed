namespace CodeEmbed.GitHub.Clients
{
    using System;
    using System.Linq;

    using CodeEmbed.GitHub.Models;

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
