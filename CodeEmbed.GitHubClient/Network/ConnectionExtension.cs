namespace CodeEmbed.GitHubClient.Network
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public static class ConnectionExtension
    {
        public static Task<TextReader> GetData(
            this IConnection connection,
            Uri uri)
        {
            return connection.GetData(uri, CancellationToken.None);
        }

        public static Task<string> GetString(
            this IConnection connection,
            Uri uri)
        {
            return GetString(connection, uri, CancellationToken.None);
        }

        public static async Task<string> GetString(
            this IConnection connection,
            Uri uri,
            CancellationToken cancellationToken)
        {
            using (var reader = await connection.GetData(uri, cancellationToken).ConfigureAwait(false))
            {
                string result = await reader.ReadToEndAsync().ConfigureAwait(false);
                return result;
            }
        }
    }
}
