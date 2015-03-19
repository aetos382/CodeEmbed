namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient;

    [GeneratedCode("ModelExtension.tt", "1.0")]
    [DebuggerStepThrough]
    public static partial class CommitSignatureExtension
    {
        public static CommitSignature Wrap(
            this ICommitSignature commitSignature,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(commitSignature != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = new CommitSignature(commitSignature, client);

            return wrapped;
        }

        public static async Task<CommitSignature> Wrap(
            this Task<ICommitSignature> commitSignature,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(commitSignature != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = Wrap(await commitSignature.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<CommitSignature> GetCommitSignature(
            this IGitHubClient client,
            Uri uri,
            IDictionary<string, string> requestHeaders,
            Encoding responseEncoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<ICommitSignature>(uri, requestHeaders, responseEncoding, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<CommitSignature> GetCommitSignature(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetCommitSignature(client, uri, null, null, CancellationToken.None);

            return result;
        }
    }
}
