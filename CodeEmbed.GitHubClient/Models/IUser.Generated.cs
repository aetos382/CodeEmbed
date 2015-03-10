








namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.Contracts;
    
    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface IUser
        : IRepositoryUser
    {
        /// <summary>Map to "name"</summary>
        String Name { [Pure] get; }

        /// <summary>Map to "company"</summary>
        String Company { [Pure] get; }

        /// <summary>Map to "blog"</summary>
        Uri Blog { [Pure] get; }

        /// <summary>Map to "location"</summary>
        String Location { [Pure] get; }

        /// <summary>Map to "email"</summary>
        String Email { [Pure] get; }

        /// <summary>Map to "hireable"</summary>
        Boolean Hireable { [Pure] get; }

        /// <summary>Map to "bio"</summary>
        String Bio { [Pure] get; }

        /// <summary>Map to "public_repos"</summary>
        Int32 PublicRepositories { [Pure] get; }

        /// <summary>Map to "public_gists"</summary>
        Int32 PublicGists { [Pure] get; }

        /// <summary>Map to "followers"</summary>
        Int32 Followers { [Pure] get; }

        /// <summary>Map to "following"</summary>
        Int32 Following { [Pure] get; }

        /// <summary>Map to "created_at"</summary>
        DateTime CreatedAt { [Pure] get; }

        /// <summary>Map to "updated_at"</summary>
        DateTime UpdatedAt { [Pure] get; }

    }
}
