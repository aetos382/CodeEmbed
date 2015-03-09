








namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.Contracts;
    
    using CodeEmbed.GitHubClient;
    
    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface IGitObject
    {
        /// <summary>Map to "type"</summary>
        String ObjectType { [Pure] get; }

        /// <summary>Map to "sha"</summary>
        String Hash { [Pure] get; }

        /// <summary>Map to "url"</summary>
        Uri Uri { [Pure] get; }

    }
}
