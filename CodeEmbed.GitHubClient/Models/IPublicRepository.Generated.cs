








namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.Contracts;
    
    [GeneratedCode("ModelInterface.tt", "1.0")]
    [ContractClass(typeof(PublicRepositoryContract))]
    public partial interface IPublicRepository
    {
        /// <summary>Map to "id"</summary>
        Int64 Id { [Pure] get; }

        /// <summary>Map to "owner"</summary>
        IRepositoryUser Owner { [Pure] get; }

        /// <summary>Map to "name"</summary>
        String Name { [Pure] get; }

        /// <summary>Map to "full_name"</summary>
        String FullName { [Pure] get; }

        /// <summary>Map to "description"</summary>
        String Description { [Pure] get; }

        /// <summary>Map to "private"</summary>
        Boolean IsPrivate { [Pure] get; }

        /// <summary>Map to "fork"</summary>
        Boolean Fork { [Pure] get; }

        /// <summary>Map to "url"</summary>
        Uri Uri { [Pure] get; }

        /// <summary>Map to "html_url"</summary>
        Uri HtmlUri { [Pure] get; }

    }
}
