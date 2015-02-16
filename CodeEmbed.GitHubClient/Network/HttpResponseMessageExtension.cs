namespace CodeEmbed.GitHubClient.Network
{
    using System;
    using System.Linq;
    using System.Net.Http;
    using System.Text;

    public static class HttpResponseMessageExtension
    {
        public static Encoding GetContentEncoding(
            this HttpResponseMessage response)
        {
            string charSet = response.Content.Headers.ContentType.CharSet;

            Encoding encoding = Encoding.GetEncoding(charSet);

            return encoding;
        }
    }
}
