namespace CodeEmbed.GitHubClient.Network
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Net.Http;
    using System.Text;

    public static class HttpResponseMessageExtension
    {
        public static Encoding GetContentEncoding(
            this HttpResponseMessage response)
        {
            Contract.Requires<ArgumentNullException>(response != null);

            if (response.Content.Headers.ContentType == null)
            {
                return null;
            }

            string charSet = response.Content.Headers.ContentType.CharSet;
            if (string.IsNullOrEmpty(charSet))
            {
                return null;
            }

            Encoding encoding = Encoding.GetEncoding(charSet);

            return encoding;
        }
    }
}
