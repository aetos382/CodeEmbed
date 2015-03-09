








namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.Contracts;
    
    using CodeEmbed.GitHubClient;
    
    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface IUserPlan
    {
        /// <summary>Map to "name"</summary>
        String Name { [Pure] get; }

        /// <summary>Map to "space"</summary>
        Int64 Space { [Pure] get; }

        /// <summary>Map to "private_repos"</summary>
        Int32 PrivateRepositories { [Pure] get; }

        /// <summary>Map to "collaborators"</summary>
        Int32 Collaborators { [Pure] get; }

    }
}
