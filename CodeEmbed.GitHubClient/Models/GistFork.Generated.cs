








namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    
    using CodeEmbed.GitHubClient;
    
    [GeneratedCode("ModelClass.tt", "1.0")]
    [DebuggerStepThrough]
    public partial class GistFork :
        IGistFork
    {
        private readonly IGistFork _gistFork = null;

		[ContractPublicPropertyName("User")]
		private readonly RepositoryUser _user = null;

        [ContractPublicPropertyName("Client")]
        private readonly IGitHubClient _client = null;

        /// <summary>Create new instance of GistFork.</summary>
        public GistFork(
            IGistFork gistFork,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistFork != null);

            Contract.Requires<ArgumentNullException>(client != null);

            this._gistFork = gistFork;

			if (gistFork.User != null)
			{
			    this._user = new RepositoryUser(gistFork.User, client);
			}

            this._client = client;
        }

        /// <summary>Map to "user"</summary>
        public RepositoryUser User
        {
            get
            {
				return this._user;
            }
        }

        /// <summary>Map to "url"</summary>
        public Uri Uri
        {
            get
            {
                return this._gistFork.Uri;
            }
        }

        /// <summary>Map to "id"</summary>
        public String Id
        {
            get
            {
                return this._gistFork.Id;
            }
        }

        /// <summary>Map to "created_at"</summary>
        public DateTime CreatedAt
        {
            get
            {
                return this._gistFork.CreatedAt;
            }
        }

        /// <summary>Map to "updated_at"</summary>
        public DateTime UpdatedAt
        {
            get
            {
                return this._gistFork.UpdatedAt;
            }
        }

        /// <summary>Map to "user"</summary>
        IRepositoryUser IGistFork.User
        {
            get
            {
                return this._gistFork.User;
            }
        }

        public IGitHubClient Client
        {
            get
            {
                Contract.Ensures(Contract.Result<IGitHubClient>() != null);

                return this._client;
            }
        }

        /// <summary>Specifies invariant contracts of object.</summary>
        [Conditional("CONTRACTS_FULL")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._gistFork != null);

            Contract.Invariant(this._client != null);
        }
    }
}
