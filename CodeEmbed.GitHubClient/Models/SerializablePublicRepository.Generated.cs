namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;

    using Newtonsoft.Json;

    [GeneratedCode("SerializableClass.tt", "1.0")]
    [DebuggerStepThrough]
    [JsonObject]
    public partial class SerializablePublicRepository :
        IPublicRepository
    {
        [ContractPublicPropertyName("Id")]
        private readonly Int64 _id;

        [ContractPublicPropertyName("Name")]
        private readonly String _name;

        [ContractPublicPropertyName("FullName")]
        private readonly String _fullName;

        [ContractPublicPropertyName("Owner")]
        private readonly SerializableRepositoryUser _owner;

        [ContractPublicPropertyName("IsPrivate")]
        private readonly Boolean _isPrivate;

        [ContractPublicPropertyName("HtmlUri")]
        private readonly Uri _htmlUri;

        [ContractPublicPropertyName("Description")]
        private readonly String _description;

        [ContractPublicPropertyName("Fork")]
        private readonly Boolean _fork;

        [ContractPublicPropertyName("Uri")]
        private readonly Uri _uri;

        [ContractPublicPropertyName("ForksUri")]
        private readonly Uri _forksUri;

        [ContractPublicPropertyName("KeysUri")]
        private readonly String _keysUri;

        [ContractPublicPropertyName("CollaboratorsUri")]
        private readonly String _collaboratorsUri;

        [ContractPublicPropertyName("TeamsUri")]
        private readonly Uri _teamsUri;

        [ContractPublicPropertyName("HooksUri")]
        private readonly Uri _hooksUri;

        [ContractPublicPropertyName("IssueEventsUri")]
        private readonly String _issueEventsUri;

        [ContractPublicPropertyName("EventsUri")]
        private readonly Uri _eventsUri;

        [ContractPublicPropertyName("AssigneesUri")]
        private readonly String _assigneesUri;

        [ContractPublicPropertyName("BranchesUri")]
        private readonly String _branchesUri;

        [ContractPublicPropertyName("TagsUri")]
        private readonly Uri _tagsUri;

        [ContractPublicPropertyName("BlobsUri")]
        private readonly String _blobsUri;

        [ContractPublicPropertyName("GitTagsUri")]
        private readonly String _gitTagsUri;

        [ContractPublicPropertyName("GitReferenesUri")]
        private readonly String _gitReferenesUri;

        [ContractPublicPropertyName("TreesUri")]
        private readonly String _treesUri;

        [ContractPublicPropertyName("StatusesUri")]
        private readonly String _statusesUri;

        [ContractPublicPropertyName("LanguagesUri")]
        private readonly Uri _languagesUri;

        [ContractPublicPropertyName("StargazersUri")]
        private readonly Uri _stargazersUri;

        [ContractPublicPropertyName("ContributorsUri")]
        private readonly Uri _contributorsUri;

        [ContractPublicPropertyName("SubscribersUri")]
        private readonly Uri _subscribersUri;

        [ContractPublicPropertyName("SubscriptionUri")]
        private readonly Uri _subscriptionUri;

        [ContractPublicPropertyName("CommitsUri")]
        private readonly String _commitsUri;

        [ContractPublicPropertyName("GitCommitsUri")]
        private readonly String _gitCommitsUri;

        [ContractPublicPropertyName("CommentsUri")]
        private readonly string _commentsUri;

        [ContractPublicPropertyName("IssueCommentUri")]
        private readonly String _issueCommentUri;

        [ContractPublicPropertyName("ContentsUri")]
        private readonly String _contentsUri;

        [ContractPublicPropertyName("CompareUri")]
        private readonly String _compareUri;

        [ContractPublicPropertyName("MergesUri")]
        private readonly Uri _mergesUri;

        [ContractPublicPropertyName("ArchiveUri")]
        private readonly String _archiveUri;

        [ContractPublicPropertyName("DownloadsUri")]
        private readonly Uri _downloadsUri;

        [ContractPublicPropertyName("IssuesUri")]
        private readonly String _issuesUri;

        [ContractPublicPropertyName("PullsUri")]
        private readonly String _pullsUri;

        [ContractPublicPropertyName("MilestonesUri")]
        private readonly String _milestonesUri;

        [ContractPublicPropertyName("NotificationsUri")]
        private readonly String _notificationsUri;

        [ContractPublicPropertyName("LabelsUri")]
        private readonly String _labelsUri;

        [ContractPublicPropertyName("ReleasesUri")]
        private readonly String _releasesUri;

        /// <summary>Create new instance of SerializablePublicRepository.</summary>
        [JsonConstructor]
        public SerializablePublicRepository(
            Int64 id,
            String name,
            String fullName,
            SerializableRepositoryUser owner,
            Boolean isPrivate,
            Uri htmlUri,
            String description,
            Boolean fork,
            Uri uri,
            Uri forksUri,
            String keysUri,
            String collaboratorsUri,
            Uri teamsUri,
            Uri hooksUri,
            String issueEventsUri,
            Uri eventsUri,
            String assigneesUri,
            String branchesUri,
            Uri tagsUri,
            String blobsUri,
            String gitTagsUri,
            String gitReferenesUri,
            String treesUri,
            String statusesUri,
            Uri languagesUri,
            Uri stargazersUri,
            Uri contributorsUri,
            Uri subscribersUri,
            Uri subscriptionUri,
            String commitsUri,
            String gitCommitsUri,
            string commentsUri,
            String issueCommentUri,
            String contentsUri,
            String compareUri,
            Uri mergesUri,
            String archiveUri,
            Uri downloadsUri,
            String issuesUri,
            String pullsUri,
            String milestonesUri,
            String notificationsUri,
            String labelsUri,
            String releasesUri)
        {
            Contract.Requires<ArgumentNullException>(name != null);
            Contract.Requires<ArgumentNullException>(owner != null);

            this._id = id;
            this._name = name;
            this._fullName = fullName;
            this._owner = owner;
            this._isPrivate = isPrivate;
            this._htmlUri = htmlUri;
            this._description = description;
            this._fork = fork;
            this._uri = uri;
            this._forksUri = forksUri;
            this._keysUri = keysUri;
            this._collaboratorsUri = collaboratorsUri;
            this._teamsUri = teamsUri;
            this._hooksUri = hooksUri;
            this._issueEventsUri = issueEventsUri;
            this._eventsUri = eventsUri;
            this._assigneesUri = assigneesUri;
            this._branchesUri = branchesUri;
            this._tagsUri = tagsUri;
            this._blobsUri = blobsUri;
            this._gitTagsUri = gitTagsUri;
            this._gitReferenesUri = gitReferenesUri;
            this._treesUri = treesUri;
            this._statusesUri = statusesUri;
            this._languagesUri = languagesUri;
            this._stargazersUri = stargazersUri;
            this._contributorsUri = contributorsUri;
            this._subscribersUri = subscribersUri;
            this._subscriptionUri = subscriptionUri;
            this._commitsUri = commitsUri;
            this._gitCommitsUri = gitCommitsUri;
            this._commentsUri = commentsUri;
            this._issueCommentUri = issueCommentUri;
            this._contentsUri = contentsUri;
            this._compareUri = compareUri;
            this._mergesUri = mergesUri;
            this._archiveUri = archiveUri;
            this._downloadsUri = downloadsUri;
            this._issuesUri = issuesUri;
            this._pullsUri = pullsUri;
            this._milestonesUri = milestonesUri;
            this._notificationsUri = notificationsUri;
            this._labelsUri = labelsUri;
            this._releasesUri = releasesUri;
        }

        /// <summary>Map to "id"</summary>
        [JsonProperty("id")]
        public Int64 Id
        {
            get
            {
                return this._id;
            }
        }

        /// <summary>Map to "name"</summary>
        [JsonProperty("name")]
        public String Name
        {
            get
            {
                Contract.Ensures(Contract.Result<String>() != null);

                return this._name;
            }
        }

        /// <summary>Map to "full_name"</summary>
        [JsonProperty("full_name")]
        public String FullName
        {
            get
            {
                return this._fullName;
            }
        }

        /// <summary>Map to "owner"</summary>
        [JsonProperty("owner")]
        public SerializableRepositoryUser Owner
        {
            get
            {
                Contract.Ensures(Contract.Result<SerializableRepositoryUser>() != null);

                return this._owner;
            }
        }

        /// <summary>Map to "private"</summary>
        [JsonProperty("private")]
        public Boolean IsPrivate
        {
            get
            {
                return this._isPrivate;
            }
        }

        /// <summary>Map to "html_url"</summary>
        [JsonProperty("html_url")]
        public Uri HtmlUri
        {
            get
            {
                return this._htmlUri;
            }
        }

        /// <summary>Map to "description"</summary>
        [JsonProperty("description")]
        public String Description
        {
            get
            {
                return this._description;
            }
        }

        /// <summary>Map to "fork"</summary>
        [JsonProperty("fork")]
        public Boolean Fork
        {
            get
            {
                return this._fork;
            }
        }

        /// <summary>Map to "url"</summary>
        [JsonProperty("url")]
        public Uri Uri
        {
            get
            {
                return this._uri;
            }
        }

        /// <summary>Map to "forks_url"</summary>
        [JsonProperty("forks_url")]
        public Uri ForksUri
        {
            get
            {
                return this._forksUri;
            }
        }

        /// <summary>Map to "keys_url"</summary>
        [JsonProperty("keys_url")]
        public String KeysUri
        {
            get
            {
                return this._keysUri;
            }
        }

        /// <summary>Map to "collaborators_url"</summary>
        [JsonProperty("collaborators_url")]
        public String CollaboratorsUri
        {
            get
            {
                return this._collaboratorsUri;
            }
        }

        /// <summary>Map to "teams_url"</summary>
        [JsonProperty("teams_url")]
        public Uri TeamsUri
        {
            get
            {
                return this._teamsUri;
            }
        }

        /// <summary>Map to "hooks_url"</summary>
        [JsonProperty("hooks_url")]
        public Uri HooksUri
        {
            get
            {
                return this._hooksUri;
            }
        }

        /// <summary>Map to "issue_events_url"</summary>
        [JsonProperty("issue_events_url")]
        public String IssueEventsUri
        {
            get
            {
                return this._issueEventsUri;
            }
        }

        /// <summary>Map to "events_url"</summary>
        [JsonProperty("events_url")]
        public Uri EventsUri
        {
            get
            {
                return this._eventsUri;
            }
        }

        /// <summary>Map to "assignees_url"</summary>
        [JsonProperty("assignees_url")]
        public String AssigneesUri
        {
            get
            {
                return this._assigneesUri;
            }
        }

        /// <summary>Map to "branches_url"</summary>
        [JsonProperty("branches_url")]
        public String BranchesUri
        {
            get
            {
                return this._branchesUri;
            }
        }

        /// <summary>Map to "tags_url"</summary>
        [JsonProperty("tags_url")]
        public Uri TagsUri
        {
            get
            {
                return this._tagsUri;
            }
        }

        /// <summary>Map to "blobs_url"</summary>
        [JsonProperty("blobs_url")]
        public String BlobsUri
        {
            get
            {
                return this._blobsUri;
            }
        }

        /// <summary>Map to "git_tags_url"</summary>
        [JsonProperty("git_tags_url")]
        public String GitTagsUri
        {
            get
            {
                return this._gitTagsUri;
            }
        }

        /// <summary>Map to "git_refs_url"</summary>
        [JsonProperty("git_refs_url")]
        public String GitReferenesUri
        {
            get
            {
                return this._gitReferenesUri;
            }
        }

        /// <summary>Map to "trees_url"</summary>
        [JsonProperty("trees_url")]
        public String TreesUri
        {
            get
            {
                return this._treesUri;
            }
        }

        /// <summary>Map to "statuses_url"</summary>
        [JsonProperty("statuses_url")]
        public String StatusesUri
        {
            get
            {
                return this._statusesUri;
            }
        }

        /// <summary>Map to "languages_url"</summary>
        [JsonProperty("languages_url")]
        public Uri LanguagesUri
        {
            get
            {
                return this._languagesUri;
            }
        }

        /// <summary>Map to "stargazers_url"</summary>
        [JsonProperty("stargazers_url")]
        public Uri StargazersUri
        {
            get
            {
                return this._stargazersUri;
            }
        }

        /// <summary>Map to "contributos_url"</summary>
        [JsonProperty("contributos_url")]
        public Uri ContributorsUri
        {
            get
            {
                return this._contributorsUri;
            }
        }

        /// <summary>Map to "subscribers_url"</summary>
        [JsonProperty("subscribers_url")]
        public Uri SubscribersUri
        {
            get
            {
                return this._subscribersUri;
            }
        }

        /// <summary>Map to "subscription_url"</summary>
        [JsonProperty("subscription_url")]
        public Uri SubscriptionUri
        {
            get
            {
                return this._subscriptionUri;
            }
        }

        /// <summary>Map to "commits_url"</summary>
        [JsonProperty("commits_url")]
        public String CommitsUri
        {
            get
            {
                return this._commitsUri;
            }
        }

        /// <summary>Map to "git_commits_url"</summary>
        [JsonProperty("git_commits_url")]
        public String GitCommitsUri
        {
            get
            {
                return this._gitCommitsUri;
            }
        }

        /// <summary>Map to "comments_url"</summary>
        [JsonProperty("comments_url")]
        public string CommentsUri
        {
            get
            {
                return this._commentsUri;
            }
        }

        /// <summary>Map to "issue_comment_url"</summary>
        [JsonProperty("issue_comment_url")]
        public String IssueCommentUri
        {
            get
            {
                return this._issueCommentUri;
            }
        }

        /// <summary>Map to "contents_url"</summary>
        [JsonProperty("contents_url")]
        public String ContentsUri
        {
            get
            {
                return this._contentsUri;
            }
        }

        /// <summary>Map to "compare_url"</summary>
        [JsonProperty("compare_url")]
        public String CompareUri
        {
            get
            {
                return this._compareUri;
            }
        }

        /// <summary>Map to "merges_url"</summary>
        [JsonProperty("merges_url")]
        public Uri MergesUri
        {
            get
            {
                return this._mergesUri;
            }
        }

        /// <summary>Map to "archive_url"</summary>
        [JsonProperty("archive_url")]
        public String ArchiveUri
        {
            get
            {
                return this._archiveUri;
            }
        }

        /// <summary>Map to "downloads_url"</summary>
        [JsonProperty("downloads_url")]
        public Uri DownloadsUri
        {
            get
            {
                return this._downloadsUri;
            }
        }

        /// <summary>Map to "issues_url"</summary>
        [JsonProperty("issues_url")]
        public String IssuesUri
        {
            get
            {
                return this._issuesUri;
            }
        }

        /// <summary>Map to "pulls_url"</summary>
        [JsonProperty("pulls_url")]
        public String PullsUri
        {
            get
            {
                return this._pullsUri;
            }
        }

        /// <summary>Map to "milestones_url"</summary>
        [JsonProperty("milestones_url")]
        public String MilestonesUri
        {
            get
            {
                return this._milestonesUri;
            }
        }

        /// <summary>Map to "notifications_url"</summary>
        [JsonProperty("notifications_url")]
        public String NotificationsUri
        {
            get
            {
                return this._notificationsUri;
            }
        }

        /// <summary>Map to "labels_url"</summary>
        [JsonProperty("labels_url")]
        public String LabelsUri
        {
            get
            {
                return this._labelsUri;
            }
        }

        /// <summary>Map to "releases_url"</summary>
        [JsonProperty("releases_url")]
        public String ReleasesUri
        {
            get
            {
                return this._releasesUri;
            }
        }

        /// <summary>Map to "owner"</summary>
        IRepositoryUser IPublicRepository.Owner
        {
            get
            {
                return this.Owner;
            }
        }

        /// <summary>Specifies invariant contracts of object.</summary>
        [Conditional("CONTRACTS_FULL")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [ContractInvariantMethod]
        private void ObjectInvariant()
        {
            Contract.Invariant(this._name != null);
            Contract.Invariant(this._owner != null);
        }
    }
}
