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

        /// <summary>Map to "owner"</summary>
        public RepositoryUser Owner
        {
            get
            {
                Contract.Ensures(Contract.Result<RepositoryUser>() != null);

                return this._owner;
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

        /// <summary>Map to "html_url"</summary>
        public Uri HtmlUri
        {
            get
            {
                return this._publicRepository.HtmlUri;
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

        /// <summary>Map to "forks_url"</summary>
        public Uri ForksUri
        {
            get
            {
                return this._publicRepository.ForksUri;
            }
        }

        /// <summary>Map to "keys_url"</summary>
        public String KeysUri
        {
            get
            {
                return this._publicRepository.KeysUri;
            }
        }

        /// <summary>Map to "collaborators_url"</summary>
        public String CollaboratorsUri
        {
            get
            {
                return this._publicRepository.CollaboratorsUri;
            }
        }

        /// <summary>Map to "teams_url"</summary>
        public Uri TeamsUri
        {
            get
            {
                return this._publicRepository.TeamsUri;
            }
        }

        /// <summary>Map to "hooks_url"</summary>
        public Uri HooksUri
        {
            get
            {
                return this._publicRepository.HooksUri;
            }
        }

        /// <summary>Map to "issue_events_url"</summary>
        public String IssueEventsUri
        {
            get
            {
                return this._publicRepository.IssueEventsUri;
            }
        }

        /// <summary>Map to "events_url"</summary>
        public Uri EventsUri
        {
            get
            {
                return this._publicRepository.EventsUri;
            }
        }

        /// <summary>Map to "assignees_url"</summary>
        public String AssigneesUri
        {
            get
            {
                return this._publicRepository.AssigneesUri;
            }
        }

        /// <summary>Map to "branches_url"</summary>
        public String BranchesUri
        {
            get
            {
                return this._publicRepository.BranchesUri;
            }
        }

        /// <summary>Map to "tags_url"</summary>
        public Uri TagsUri
        {
            get
            {
                return this._publicRepository.TagsUri;
            }
        }

        /// <summary>Map to "blobs_url"</summary>
        public String BlobsUri
        {
            get
            {
                return this._publicRepository.BlobsUri;
            }
        }

        /// <summary>Map to "git_tags_url"</summary>
        public String GitTagsUri
        {
            get
            {
                return this._publicRepository.GitTagsUri;
            }
        }

        /// <summary>Map to "git_refs_url"</summary>
        public String GitReferenesUri
        {
            get
            {
                return this._publicRepository.GitReferenesUri;
            }
        }

        /// <summary>Map to "trees_url"</summary>
        public String TreesUri
        {
            get
            {
                return this._publicRepository.TreesUri;
            }
        }

        /// <summary>Map to "statuses_url"</summary>
        public String StatusesUri
        {
            get
            {
                return this._publicRepository.StatusesUri;
            }
        }

        /// <summary>Map to "languages_url"</summary>
        public Uri LanguagesUri
        {
            get
            {
                return this._publicRepository.LanguagesUri;
            }
        }

        /// <summary>Map to "stargazers_url"</summary>
        public Uri StargazersUri
        {
            get
            {
                return this._publicRepository.StargazersUri;
            }
        }

        /// <summary>Map to "contributos_url"</summary>
        public Uri ContributorsUri
        {
            get
            {
                return this._publicRepository.ContributorsUri;
            }
        }

        /// <summary>Map to "subscribers_url"</summary>
        public Uri SubscribersUri
        {
            get
            {
                return this._publicRepository.SubscribersUri;
            }
        }

        /// <summary>Map to "subscription_url"</summary>
        public Uri SubscriptionUri
        {
            get
            {
                return this._publicRepository.SubscriptionUri;
            }
        }

        /// <summary>Map to "commits_url"</summary>
        public String CommitsUri
        {
            get
            {
                return this._publicRepository.CommitsUri;
            }
        }

        /// <summary>Map to "git_commits_url"</summary>
        public String GitCommitsUri
        {
            get
            {
                return this._publicRepository.GitCommitsUri;
            }
        }

        /// <summary>Map to "comments_url"</summary>
        public string CommentsUri
        {
            get
            {
                return this._publicRepository.CommentsUri;
            }
        }

        /// <summary>Map to "issue_comment_url"</summary>
        public String IssueCommentUri
        {
            get
            {
                return this._publicRepository.IssueCommentUri;
            }
        }

        /// <summary>Map to "contents_url"</summary>
        public String ContentsUri
        {
            get
            {
                return this._publicRepository.ContentsUri;
            }
        }

        /// <summary>Map to "compare_url"</summary>
        public String CompareUri
        {
            get
            {
                return this._publicRepository.CompareUri;
            }
        }

        /// <summary>Map to "merges_url"</summary>
        public Uri MergesUri
        {
            get
            {
                return this._publicRepository.MergesUri;
            }
        }

        /// <summary>Map to "archive_url"</summary>
        public String ArchiveUri
        {
            get
            {
                return this._publicRepository.ArchiveUri;
            }
        }

        /// <summary>Map to "downloads_url"</summary>
        public Uri DownloadsUri
        {
            get
            {
                return this._publicRepository.DownloadsUri;
            }
        }

        /// <summary>Map to "issues_url"</summary>
        public String IssuesUri
        {
            get
            {
                return this._publicRepository.IssuesUri;
            }
        }

        /// <summary>Map to "pulls_url"</summary>
        public String PullsUri
        {
            get
            {
                return this._publicRepository.PullsUri;
            }
        }

        /// <summary>Map to "milestones_url"</summary>
        public String MilestonesUri
        {
            get
            {
                return this._publicRepository.MilestonesUri;
            }
        }

        /// <summary>Map to "notifications_url"</summary>
        public String NotificationsUri
        {
            get
            {
                return this._publicRepository.NotificationsUri;
            }
        }

        /// <summary>Map to "labels_url"</summary>
        public String LabelsUri
        {
            get
            {
                return this._publicRepository.LabelsUri;
            }
        }

        /// <summary>Map to "releases_url"</summary>
        public String ReleasesUri
        {
            get
            {
                return this._publicRepository.ReleasesUri;
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
