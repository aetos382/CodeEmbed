namespace CodeEmbed.GitHubClient.Network
{
    using System;
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
            Encoding encoding,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(connection != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            return connection.GetAsTextReader(uri, encoding, CancellationToken.None);
        }

        public static Task<TextReader> GetAsTextReader(
            this IConnection connection,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(connection != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            return GetAsTextReader(connection, null, uri);
        }

        public static Task<string> GetString(
            this IConnection connection,
            Uri uri)
        {
            Contract.Requires<ArgumentNullException>(connection != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            return GetString(connection, uri, null);
        }

        public static Task<string> GetString(
            this IConnection connection,
            Uri uri,
            Encoding encoding)
        {
            Contract.Requires<ArgumentNullException>(connection != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            return GetString(connection, uri, encoding, CancellationToken.None);
        }

        public static async Task<string> GetString(
            this IConnection connection,
            Uri uri,
            Encoding encoding,
            CancellationToken cancellationToken)
        {
            Contract.Requires<ArgumentNullException>(connection != null);
            Contract.Requires<ArgumentNullException>(uri != null);

            using (var reader = await connection.GetAsTextReader(uri, encoding, cancellationToken).ConfigureAwait(false))
            {
                string result = await reader.ReadToEndAsync().ConfigureAwait(false);
                return result;
            }
        }
    }
}
