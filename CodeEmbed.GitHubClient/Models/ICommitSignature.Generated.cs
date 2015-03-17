namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.Contracts;

    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface ICommitSignature
    {
        /// <summary>Map to "date"</summary>
        DateTime Date { [Pure] get; }

        /// <summary>Map to "name"</summary>
        String Name { [Pure] get; }

        /// <summary>Map to "email"</summary>
        String Email { [Pure] get; }

    }
}
