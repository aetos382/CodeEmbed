








namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.Contracts;
    
    using CodeEmbed.GitHubClient;
    
    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface IPermissions
    {
        /// <summary>Map to "admin"</summary>
        Boolean Administration { [Pure] get; }

        /// <summary>Map to "push"</summary>
        Boolean Push { [Pure] get; }

        /// <summary>Map to "pull"</summary>
        Boolean Pull { [Pure] get; }

    }
}
