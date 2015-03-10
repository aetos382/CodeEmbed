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
    public partial class PublicRepository :
        IPublicRepository
    {
        private readonly IPublicRepository _publicRepository = null;

        [ContractPublicPropertyName("Owner")]
        private readonly RepositoryUser _owner = null;

        [ContractPublicPropertyName("Client")]
        private readonly IGitHubClient _client = null;

        /// <summary>Create new instance of PublicRepository.</summary>
        public PublicRepository(
            IPublicRepository publicRepository,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(publicRepository != null);

            Contract.Requires<ArgumentNullException>(client != null);

            this._publicRepository = publicRepository;

            this._owner = new RepositoryUser(publicRepository.Owner, client);

            this._client = client;
        }

        /// <summary>Map to "id"</summary>
        public Int64 Id
        {
            get
            {
                return this._publicRepository.Id;
            }
        }

        /// <summary>Map to "owner"</summary>
        public RepositoryUser Owner
        {
            get
            {
                Contract.Ensures(Contract.Result<RepositoryUser>() != null);

                return this._owner;
            }
        }

        /// <summary>Map to "name"</summary>
        public String Name
        {
            get
            {
                return this._publicRepository.Name;
            }
        }

        /// <summary>Map to "full_name"</summary>
        public String FullName
        {
            get
            {
                return this._publicRepository.FullName;
            }
        }

        /// <summary>Map to "description"</summary>
        public String Description
        {
            get
            {
                return this._publicRepository.Description;
            }
        }

        /// <summary>Map to "private"</summary>
        public Boolean IsPrivate
        {
            get
            {
                return this._publicRepository.IsPrivate;
            }
        }

        /// <summary>Map to "fork"</summary>
        public Boolean Fork
        {
            get
            {
                return this._publicRepository.Fork;
            }
        }

        /// <summary>Map to "url"</summary>
        public Uri Uri
        {
            get
            {
                return this._publicRepository.Uri;
            }
        }

        /// <summary>Map to "html_url"</summary>
        public Uri HtmlUri
        {
            get
            {
                return this._publicRepository.HtmlUri;
            }
        }

        /// <summary>Map to "owner"</summary>
        IRepositoryUser IPublicRepository.Owner
        {
            get
            {
                return this._publicRepository.Owner;
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
            Contract.Invariant(this._publicRepository != null);

            Contract.Invariant(this._owner != null);

            Contract.Invariant(this._client != null);
        }
    }
}
