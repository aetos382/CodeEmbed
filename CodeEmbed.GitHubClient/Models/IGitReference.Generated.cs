








namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.Contracts;
    
    using CodeEmbed.GitHubClient;
    
    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface IGitReference
    {
        /// <summary>Map to "ref"</summary>
        String Reference { [Pure] get; }

        /// <summary>Map to "url"</summary>
        Uri Uri { [Pure] get; }

        /// <summary>Map to "object"</summary>
        IGitObject Target { [Pure] get; }

    }
}
