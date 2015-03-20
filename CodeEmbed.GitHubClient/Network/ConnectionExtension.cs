namespace CodeEmbed.GitHubClient.Network
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public static class ConnectionExtension
    {
        public static Task<TextReader> GetAsTextReader(
            this IConnection connection,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(connection != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            return connection.GetAsTextReader(uri, null, null, CancellationToken.None);
        }

        public static Task<string> GetString(
            this IConnection connection,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(connection != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            return GetString(connection, uri, null, null, CancellationToken.None);
        }

        public static async Task<string> GetString(
            this IConnection connection,
            Uri uri,
            IDictionary<string, string> requestHeaders,
            Encoding responseEncoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(connection != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            using (var reader = await connection.GetAsTextReader(uri, requestHeaders, responseEncoding, cancellationToken).ConfigureAwait(false))
            {
                string result = await reader.ReadToEndAsync().ConfigureAwait(false);
                return result;
            }
        }
    }
}
