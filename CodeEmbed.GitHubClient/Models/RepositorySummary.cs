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

        public string KeysUri
        {
            get
            {
                return this._repositorySummary.KeysUri;
            }
        }

        public string CollaboratorsUri
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

        public string IssueEventsUri
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

        public string AssigneesUri
        {
            get
            {
                return this._repositorySummary.AssigneesUri;
            }
        }

        public string BranchesUri
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

        public string BlobsUri
        {
            get
            {
                return this._repositorySummary.BlobsUri;
            }
        }

        public string GitTagsUri
        {
            get
            {
                return this._repositorySummary.GitTagsUri;
            }
        }

        public string GitReferencesUri
        {
            get
            {
                return this._repositorySummary.GitReferencesUri;
            }
        }

        public string TreesUri
        {
            get
            {
                return this._repositorySummary.TreesUri;
            }
        }

        public string StatusesUri
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

        public string CommitsUri
        {
            get
            {
                return this._repositorySummary.CommitsUri;
            }
        }

        public string GitCommitsUri
        {
            get
            {
                return this._repositorySummary.GitCommitsUri;
            }
        }

        public string CommentsUri
        {
            get
            {
                return this._repositorySummary.CommentsUri;
            }
        }

        public string IssueCommentUri
        {
            get
            {
                return this._repositorySummary.IssueCommentUri;
            }
        }

        public string ContentsUri
        {
            get
            {
                return this._repositorySummary.ContentsUri;
            }
        }

        public string CompareUri
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

        public string ArchiveUri
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

        public string IssuesUri
        {
            get
            {
                return this._repositorySummary.IssuesUri;
            }
        }

        public string PullsUri
        {
            get
            {
                return this._repositorySummary.PullsUri;
            }
        }

        public string MilestonesUri
        {
            get
            {
                return this._repositorySummary.MilestonesUri;
            }
        }

        public string NotificationsUri
        {
            get
            {
                return this._repositorySummary.NotificationsUri;
            }
        }

        public string LabelsUri
        {
            get
            {
                return this._repositorySummary.LabelsUri;
            }
        }

        public string ReleasesUri
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
