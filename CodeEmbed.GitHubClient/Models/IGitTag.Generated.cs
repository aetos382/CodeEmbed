namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.Contracts;

    [GeneratedCode("ModelInterface.tt", "1.0")]
    public partial interface IGitTag
    {
        /// <summary>Map to "tag"</summary>
        String Tag { [Pure] get; }

        /// <summary>Map to "sha"</summary>
        String Hash { [Pure] get; }

        /// <summary>Map to "url"</summary>
        Uri Uri { [Pure] get; }

        /// <summary>Map to "message"</summary>
        String Message { [Pure] get; }

        /// <summary>Map to "tagger"</summary>
        ISignature Tagger { [Pure] get; }

        /// <summary>Map to "object"</summary>
        IGitObject Target { [Pure] get; }

    }
}
