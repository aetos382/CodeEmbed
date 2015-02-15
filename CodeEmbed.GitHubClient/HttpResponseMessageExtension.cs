namespace CodeEmbed.GitHubClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;

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
