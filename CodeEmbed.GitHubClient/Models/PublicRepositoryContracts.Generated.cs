namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;

    /// <summary>Contract class for IPublicRepository.</summary>
    [GeneratedCode("ModelContract.tt", "1.0")]
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [ContractClassFor(typeof(IPublicRepository))]
    public abstract partial class PublicRepositoryContract :
        IPublicRepository
    {
        /// <summary>Map to "id"</summary>
        public abstract Int64 Id { get; }

        /// <summary>Map to "owner"</summary>
        public IRepositoryUser Owner
        {
            get
            {
                Contract.Ensures(Contract.Result<IRepositoryUser>() != null);

                throw new NotImplementedException();
            }
        }

        /// <summary>Map to "name"</summary>
        public String Name
        {
            get
            {
                Contract.Ensures(Contract.Result<String>() != null);

                throw new NotImplementedException();
            }
        }

        /// <summary>Map to "full_name"</summary>
        public abstract String FullName { get; }

        /// <summary>Map to "description"</summary>
        public abstract String Description { get; }

        /// <summary>Map to "private"</summary>
        public abstract Boolean IsPrivate { get; }

        /// <summary>Map to "fork"</summary>
        public abstract Boolean Fork { get; }

        /// <summary>Map to "url"</summary>
        public abstract Uri Uri { get; }

        /// <summary>Map to "html_url"</summary>
        public abstract Uri HtmlUri { get; }

    }
}
