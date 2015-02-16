namespace CodeEmbed.GitHubClient.Models
{
    //// GET /repos/:owner/:repo
    
    using System;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;

    public class Repository :
        RepositorySummary,
        IRepository
    {
        private readonly IRepository _repository;

        public Repository(
            IRepository repository,
            IGitHubClient client)
            : base(repository, client)
        {
            Contract.Requires<ArgumentNullException>(repository != null);
            Contract.Requires<ArgumentNullException>(client != null);

            this._repository = repository;
        }

        public DateTime CreatedAt
        {
            get
            {
                return this._repository.CreatedAt;
            }
        }

        public DateTime UpdatedAt
        {
            get
            {
                return this._repository.UpdatedAt;
            }
        }

        public DateTime PushedAt
        {
            get
            {
                return this._repository.PushedAt;
            }
        }

        public Uri GitUri
        {
            get
            {
                return this._repository.GitUri;
            }
        }

        public string SshUri
        {
            get
            {
                return this._repository.SshUri;
            }
        }

        public Uri CloneUri
        {
            get
            {
                return this._repository.CloneUri;
            }
        }

        public Uri SvnUri
        {
            get
            {
                return this._repository.SvnUri;
            }
        }

        public string Homepage
        {
            get
            {
                return this._repository.Homepage;
            }
        }

        public long Size
        {
            get
            {
                return this._repository.Size;
            }
        }

        public int StargazersCount
        {
            get
            {
                return this._repository.StargazersCount;
            }
        }

        public int WatchersCount
        {
            get
            {
                return this._repository.WatchersCount;
            }
        }

        public string Language
        {
            get
            {
                return this._repository.Language;
            }
        }

        public bool HasIssues
        {
            get
            {
                return this._repository.HasIssues;
            }
        }

        public bool HasDownloads
        {
            get
            {
                return this._repository.HasDownloads;
            }
        }

        public bool HasWiki
        {
            get
            {
                return this._repository.HasWiki;
            }
        }

        public bool HasPages
        {
            get
            {
                return this._repository.HasPages;
            }
        }

        public int ForksCount
        {
            get
            {
                return this._repository.ForksCount;
            }
        }

        public Uri MirrorUri
        {
            get
            {
                return this._repository.MirrorUri;
            }
        }

        public int OpenIssuesCount
        {
            get
            {
                return this._repository.OpenIssuesCount;
            }
        }

        public int Forks
        {
            get
            {
                return this._repository.Forks;
            }
        }

        public int OpenIssues
        {
            get
            {
                return this._repository.OpenIssues;
            }
        }

        public int Watchers
        {
            get
            {
                return this._repository.Watchers;
            }
        }

        public string DefaultBranch
        {
            get
            {
                return this._repository.DefaultBranch;
            }
        }

        [Conditional("CONTRACTS_FULL")]
        [ContractInvariantMethod]
        [DebuggerStepThrough]
        [DebuggerHidden]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._repository != null);
        }
    }
}
