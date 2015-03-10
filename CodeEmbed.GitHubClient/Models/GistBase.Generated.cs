








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
    public abstract partial class GistBase :
        IGistBase
    {
        private readonly IGistBase _gistBase = null;

		[ContractPublicPropertyName("Owner")]
		private readonly RepositoryUser _owner = null;

        [ContractPublicPropertyName("Client")]
        private readonly IGitHubClient _client = null;

        /// <summary>Create new instance of GistBase.</summary>
        protected GistBase(
            IGistBase gistBase,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(gistBase != null);

            Contract.Requires<ArgumentNullException>(client != null);

            this._gistBase = gistBase;

			if (gistBase.Owner != null)
			{
			    this._owner = new RepositoryUser(gistBase.Owner, client);
			}

            this._client = client;
        }

        /// <summary>Map to "url"</summary>
        public Uri Uri
        {
            get
            {
                return this._gistBase.Uri;
            }
        }

        /// <summary>Map to "forks_url"</summary>
        public Uri ForksUri
        {
            get
            {
                return this._gistBase.ForksUri;
            }
        }

        /// <summary>Map to "commits_url"</summary>
        public Uri CommitsUri
        {
            get
            {
                return this._gistBase.CommitsUri;
            }
        }

        /// <summary>Map to "id"</summary>
        public String Id
        {
            get
            {
                return this._gistBase.Id;
            }
        }

        /// <summary>Map to "description"</summary>
        public String Description
        {
            get
            {
                return this._gistBase.Description;
            }
        }

        /// <summary>Map to "public"</summary>
        public Boolean IsPublic
        {
            get
            {
                return this._gistBase.IsPublic;
            }
        }

        /// <summary>Map to "owner"</summary>
        public RepositoryUser Owner
        {
            get
            {
				return this._owner;
            }
        }

        /// <summary>Map to "user"</summary>
        public String User
        {
            get
            {
                return this._gistBase.User;
            }
        }

        /// <summary>Map to "comments"</summary>
        public Int32 Comments
        {
            get
            {
                return this._gistBase.Comments;
            }
        }

        /// <summary>Map to "comments_url"</summary>
        public Uri CommentsUri
        {
            get
            {
                return this._gistBase.CommentsUri;
            }
        }

        /// <summary>Map to "html_url"</summary>
        public Uri HtmlUri
        {
            get
            {
                return this._gistBase.HtmlUri;
            }
        }

        /// <summary>Map to "git_pull_url"</summary>
        public Uri GitPullUri
        {
            get
            {
                return this._gistBase.GitPullUri;
            }
        }

        /// <summary>Map to "git_push_url"</summary>
        public Uri GitPushUri
        {
            get
            {
                return this._gistBase.GitPushUri;
            }
        }

        /// <summary>Map to "created_at"</summary>
        public DateTime CreatedAt
        {
            get
            {
                return this._gistBase.CreatedAt;
            }
        }

        /// <summary>Map to "updated_at"</summary>
        public DateTime UpdatedAt
        {
            get
            {
                return this._gistBase.UpdatedAt;
            }
        }

        /// <summary>Map to "owner"</summary>
        IRepositoryUser IGistBase.Owner
        {
            get
            {
                return this._gistBase.Owner;
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
            Contract.Invariant(this._gistBase != null);

            Contract.Invariant(this._client != null);
        }
    }
}
