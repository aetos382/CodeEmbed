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
    public static partial class SignatureExtension
    {
        public static Signature Wrap(
            this ISignature signature,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(signature != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = new Signature(signature, client);

            return wrapped;
        }

        public static async Task<Signature> Wrap(
            this Task<ISignature> signature,
            IGitHubClient client)
        {
            Contract.Requires<ArgumentNullException>(signature != null);
            Contract.Requires<ArgumentNullException>(client != null);

            var wrapped = Wrap(await signature.ConfigureAwait(false), client);

            return wrapped;
        }

        public static async Task<Signature> GetSignature(
            this IGitHubClient client,
            Uri uri,
            IDictionary<string, string> requestHeaders,
            Encoding responseEncoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = await client.GetData<ISignature>(uri, requestHeaders, responseEncoding, cancellationToken).ConfigureAwait(false);
            var wrapped = Wrap(result, client);

            return wrapped;
        }

        public static Task<Signature> GetSignature(
            this IGitHubClient client,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(client != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            var result = GetSignature(client, uri, null, null, CancellationToken.None);

            return result;
        }
    }
}
