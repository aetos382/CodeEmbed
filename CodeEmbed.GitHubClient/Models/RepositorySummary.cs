namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;

    using CodeEmbed.GitHubClient.Models.Internal;

    public class RepositorySummary :
        ModelBase,
        IRepositorySummary
    {
        private readonly IRepositorySummary _repositorySummary;

        public RepositorySummary(
            IRepositorySummary repositorySummary,
            IGitHubClient client)
            : base(client)
        {
            Contract.Requires<ArgumentNullException>(repositorySummary != null);
            Contract.Requires<ArgumentNullException>(client != null);

            this._repositorySummary = repositorySummary;
        }

        public long Id
        {
            get
            {
                return this._repositorySummary.Id;
            }
        }

        public string Name
        {
            get
            {
                return this._repositorySummary.Name;
            }
        }

        public string FullName
        {
            get
            {
                return this._repositorySummary.FullName;
            }
        }

        public IRepositoryUser Owner
        {
            get
            {
                return this._repositorySummary.Owner;
            }
        }

        public bool Private
        {
            get
            {
                return this._repositorySummary.Private;
            }
        }

        public Uri HtmlUri
        {
            get
            {
                return this._repositorySummary.HtmlUri;
            }
        }

        public string Description
        {
            get
            {
                return this._repositorySummary.Description;
            }
        }

        public bool Fork
        {
            get
            {
                return this._repositorySummary.Fork;
            }
        }

        public Uri Uri
        {
            get
            {
                return this._repositorySummary.Uri;
            }
        }

        public Uri ForksUri
        {
            get
            {
                return this._repositorySummary.ForksUri;
            }
        }

        public UriTemplate KeysUri
        {
            get
            {
                return this._repositorySummary.KeysUri;
            }
        }

        public UriTemplate CollaboratorsUri
        {
            get
            {
                return this._repositorySummary.CollaboratorsUri;
            }
        }

        public Uri TeamsUri
        {
            get
            {
                return this._repositorySummary.TeamsUri;
            }
        }

        public Uri HooksUri
        {
            get
            {
                return this._repositorySummary.HooksUri;
            }
        }

        public UriTemplate IssueEventsUri
        {
            get
            {
                return this._repositorySummary.IssueEventsUri;
            }
        }

        public Uri EventsUri
        {
            get
            {
                return this._repositorySummary.EventsUri;
            }
        }

        public UriTemplate AssigneesUri
        {
            get
            {
                return this._repositorySummary.AssigneesUri;
            }
        }

        public UriTemplate BranchesUri
        {
            get
            {
                return this._repositorySummary.BranchesUri;
            }
        }

        public Uri TagsUri
        {
            get
            {
                return this._repositorySummary.TagsUri;
            }
        }

        public UriTemplate BlobsUri
        {
            get
            {
                return this._repositorySummary.BlobsUri;
            }
        }

        public UriTemplate GitTagsUri
        {
            get
            {
                return this._repositorySummary.GitTagsUri;
            }
        }

        public UriTemplate GitReferencesUri
        {
            get
            {
                return this._repositorySummary.GitReferencesUri;
            }
        }

        public UriTemplate TreesUri
        {
            get
            {
                return this._repositorySummary.TreesUri;
            }
        }

        public UriTemplate StatusesUri
        {
            get
            {
                return this._repositorySummary.StatusesUri;
            }
        }

        public Uri LanguagesUri
        {
            get
            {
                return this._repositorySummary.LanguagesUri;
            }
        }

        public Uri StargazersUri
        {
            get
            {
                return this._repositorySummary.StargazersUri;
            }
        }

        public Uri ContributorsUri
        {
            get
            {
                return this._repositorySummary.ContributorsUri;
            }
        }

        public Uri SubscribersUri
        {
            get
            {
                return this._repositorySummary.SubscribersUri;
            }
        }

        public Uri SubscriptionUri
        {
            get
            {
                return this._repositorySummary.SubscriptionUri;
            }
        }

        public UriTemplate CommitsUri
        {
            get
            {
                return this._repositorySummary.CommitsUri;
            }
        }

        public UriTemplate GitCommitsUri
        {
            get
            {
                return this._repositorySummary.GitCommitsUri;
            }
        }

        public UriTemplate CommentsUri
        {
            get
            {
                return this._repositorySummary.CommentsUri;
            }
        }

        public UriTemplate IssueCommentUri
        {
            get
            {
                return this._repositorySummary.IssueCommentUri;
            }
        }

        public UriTemplate ContentsUri
        {
            get
            {
                return this._repositorySummary.ContentsUri;
            }
        }

        public UriTemplate CompareUri
        {
            get
            {
                return this._repositorySummary.CompareUri;
            }
        }

        public Uri MergesUri
        {
            get
            {
                return this._repositorySummary.MergesUri;
            }
        }

        public UriTemplate ArchiveUri
        {
            get
            {
                return this._repositorySummary.ArchiveUri;
            }
        }

        public Uri DownloadsUri
        {
            get
            {
                return this._repositorySummary.DownloadsUri;
            }
        }

        public UriTemplate IssuesUri
        {
            get
            {
                return this._repositorySummary.IssuesUri;
            }
        }

        public UriTemplate PullsUri
        {
            get
            {
                return this._repositorySummary.PullsUri;
            }
        }

        public UriTemplate MilestonesUri
        {
            get
            {
                return this._repositorySummary.MilestonesUri;
            }
        }

        public UriTemplate NotificationsUri
        {
            get
            {
                return this._repositorySummary.NotificationsUri;
            }
        }

        public UriTemplate LabelsUri
        {
            get
            {
                return this._repositorySummary.LabelsUri;
            }
        }

        public UriTemplate ReleasesUri
        {
            get
            {
                return this._repositorySummary.ReleasesUri;
            }
        }

        [Conditional("CONTRACTS_FULL")]
        [DebuggerStepThrough]
        [DebuggerHidden]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._repositorySummary != null);
        }
    }
}
