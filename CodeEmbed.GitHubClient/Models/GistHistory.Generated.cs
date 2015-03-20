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
    public partial class GistHistory :
        IGistHistory
    {
        private readonly IGistHistory _gistHistory = null;

        [ContractPublicPropertyName("User")]
        private readonly RepositoryUser _user = null;

        [ContractPublicPropertyName("ChangeStatus")]
        private readonly GistChangeStatus _changeStatus = null;

        [ContractPublicPropertyName("Client")]
        private readonly IGitHubClient _client = null;

        /// <summary>Create new instance of GistHistory.</summary>
        public GistHistory(
            IGistHistory gistHistory,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistHistory != null);
            Contract.Requires<ArgumentNullException>(client != null);

            this._gistHistory = gistHistory;

            if (gistHistory.User != null)
            {
                this._user = new RepositoryUser(gistHistory.User, client);
            }

            if (gistHistory.ChangeStatus != null)
            {
                this._changeStatus = new GistChangeStatus(gistHistory.ChangeStatus, client);
            }

            this._client = client;
        }

        /// <summary>Map to "url"</summary>
        public Uri Uri
        {
            get
            {
                return this._gistHistory.Uri;
            }
        }

        /// <summary>Map to "version"</summary>
        public String Version
        {
            get
            {
                return this._gistHistory.Version;
            }
        }

        /// <summary>Map to "user"</summary>
        public RepositoryUser User
        {
            get
            {
                return this._user;
            }
        }

        /// <summary>Map to "change_status"</summary>
        public GistChangeStatus ChangeStatus
        {
            get
            {
                return this._changeStatus;
            }
        }

        /// <summary>Map to "committed_at"</summary>
        public DateTime CommittedAt
        {
            get
            {
                return this._gistHistory.CommittedAt;
            }
        }

        /// <summary>Map to "user"</summary>
        IRepositoryUser IGistHistory.User
        {
            get
            {
                return this._gistHistory.User;
            }
        }

        /// <summary>Map to "change_status"</summary>
        IGistChangeStatus IGistHistory.ChangeStatus
        {
            get
            {
                return this._gistHistory.ChangeStatus;
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
            Contract.Invariant(this._gistHistory != null);
            Contract.Invariant(this._client != null);
        }
    }
}
